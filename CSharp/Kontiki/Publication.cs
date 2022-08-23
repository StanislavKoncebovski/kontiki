/***********************************************************************************
* File:         Publication.cs                                                     *
* Contents:     Class Publication                                                  *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-07-26 14:14                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Kontiki.Tools.Xml;

namespace Kontiki
{
	/// <summary>
	/// Either a book or an article (so far).
	/// </summary>
	public class Publication
	{
		#region Private ststic members
		private static List<string>			_fieldsRestricted = new List<string>{"Md5"};
		#endregion

		#region Properties
		public PublicationType				PublicationType		{get;set;}
		/// <summary>
		/// Kontiki's own ID.
		/// </summary>
		public int							Id					{get;set;}
		/// <summary>
		/// LibGen's MD5. the unique identifier of a publication on LibGen
		/// </summary>
		public string						Md5					{get;set;}
		public string						Title				{get;set;}
		public string						Subtitle			{get;set;}
		public string						Author				{get;set;}
		public string						Volume				{get;set;}
		/// <summary>
		/// For articles.
		/// </summary>
		public string						Number				{get;set;}      
		public string						Series				{get;set;}
		public string						Year				{get;set;}
		
		/// <summary>
		/// For articles.
		/// </summary>
		public string						Month				{get;set;}       
		public string						Edition				{get;set;}
		public string						Publisher			{get;set;}
		public string						Address				{get;set;}    

		/// <summary>
		/// For books.
		/// </summary>
		public string						Pagetotal			{get;set;}

		/// <summary>
		/// For articles.
		/// </summary>
		public string						Journal				{get;set;}
		
		/// <summary>
		/// For articles.
		/// </summary>
		public string						Pages				{get;set;}       
		public string						Issue				{get;set;}
		public string						Isbn				{get;set;}
		public string						Issn				{get;set;}
		public string						Doi					{get;set;}
		public string						Language			{get;set;}
		public string						Note				{get;set;}
		public string						Url					{get;set;}
		public string						UrlDate				{get;set;}
		public string						Abstract			{get;set;}

		/// <summary>
		/// Secondary and optional foreign ids, probably for a later version.
		/// Include:
		///		 libgen_id,
		///		 asin: the text's Amazon Standard Identification Number
		///		 udc: the text's Universal Decimal Classification number
		///		 ddc: the text's Dewey Decimal Classification number
		///		 lcc: the text's Library of Congress Classification number
		/// </summary>
		public Dictionary<string, string>	ForeignIdentifiers	{get;set;} = new Dictionary<string, string>();
		#endregion

		#region Construction
		public Publication(PublicationType publicationType = PublicationType.Unknown)
		{
			this.PublicationType	= publicationType;
		}
		#endregion

		#region BiBTeX
		public string ToBibTeX()
		{
			string publicationType = "";

			switch (this.PublicationType)
			{
				case PublicationType.Book:
					publicationType = "book";
					break;

				case PublicationType.Article:
					publicationType = "article";
					break;

				case PublicationType.Unknown:
				default:
					publicationType = "misc";
					break;
			}

			string result = $"@{publicationType}{{{this.PublicationType.ToString().ToLower()}_{this.Id},\r\n";

			PropertyInfo[] properties = typeof(Publication).GetProperties();

			foreach (PropertyInfo property in properties)
			{
				string key = property.Name;

				if (_fieldsRestricted.Contains(key))
				{
					continue;
				}

				object value = property.GetValue(this);

				if (value == null)
				{
					continue;
				}

				if (value is string)
				{
					string valueString = (string)value;

					if (valueString.Length == 0)
					{
						continue;
					}

					string delim = new string('\t',  (3 - ((4 + key.Length) / 5)));

					string line = $"\t{key} ={delim}{{{value}}},\r\n";

					result += line;
				}
			}

			result += "}";

			return result;
		}

		public static Publication FromBibTeX(string bibtex)
		{
			string[] lines = bibtex.Trim().Split('\n');

			if (lines.Length < 3)
			{
				return null;
			}

			Publication publication = new Publication();

			Regex rxPublicationType = new Regex(@"@\s*(?'type'\w+)\s*{");
			string publicationType = rxPublicationType.Match(lines[0]).Groups["type"].Value;

			switch (publicationType.ToLower())
			{
				case "book":
					publication.PublicationType	= PublicationType.Book;
					break;

				case "article":
					publication.PublicationType = PublicationType.Article;
					break;

				default:
					break;
			}

			foreach (string line in lines.Skip(1))
			{
				string[] cells = line.Split('=');

				if (cells.Length == 2)
				{
					string key				= cells[0].Trim();
					string value			= cells[1].Trim().Replace("{", "").Replace("},", "");
					string keyCap			= Capitalize(key);
					PropertyInfo property	= typeof(Publication).GetProperty(keyCap);
					property.SetValue(publication, value);
				}
			}

			return publication;
		}
		#endregion

		#region XML
		public XElement ToXElement()
		{
			XElement x = new XElement("Publication");

			x.Add(new XAttribute("PublicationType",	this.PublicationType));
			x.Add(new XAttribute("Id",		this.Id));

			x.Add(new XElement("Md5",		this.Md5));
			x.Add(new XElement("Title",		this.Title));
			x.Add(new XElement("Subtitle",	this.Subtitle));
			x.Add(new XElement("Author",	this.Author));

			x.Add(new XElement("Volume",	this.Volume));
			x.Add(new XElement("Number",	this.Number));
			x.Add(new XElement("Year",		this.Year));
			x.Add(new XElement("Month",		this.Month));
			x.Add(new XElement("Edition",	this.Edition));
			x.Add(new XElement("Publisher", this.Publisher));
			x.Add(new XElement("Address",	this.Address));
			x.Add(new XElement("Pagetotal", this.Pagetotal));
			x.Add(new XElement("Address",	this.Address));
			x.Add(new XElement("Journal",	this.Journal));

			x.Add(new XElement("Pages",		this.Pages));		
			x.Add(new XElement("Issue",		this.Issue));		
			x.Add(new XElement("Isbn",		this.Isbn));		
			x.Add(new XElement("Issn",		this.Issn));		
			x.Add(new XElement("Doi",		this.Doi));		
			x.Add(new XElement("Language",	this.Language));
			x.Add(new XElement("Note",		this.Note));		
			x.Add(new XElement("Url",		this.Url));			
			x.Add(new XElement("UrlDate",	this.UrlDate));
			x.Add(new XElement("Abstract",	this.Abstract));

			XElement xForeginIdentifiers	= new XElement("ForeignIds");
			x.Add(xForeginIdentifiers);

			foreach (string key in this.ForeignIdentifiers.Keys)
			{
				xForeginIdentifiers.Add(new XElement(key, this.ForeignIdentifiers[key]));
			}

			return x;
		}

		public static Publication FromXElement(XElement x)
		{
			Publication publication = new Publication();

			publication.PublicationType	= (PublicationType)x.GetAttributeEnum(typeof(PublicationType), "PublicationType", PublicationType.Unknown);
			publication.Id				= x.GetAttributeValue<int>("Id");
			publication.Md5				= x.GetElementValue<string>("Md5");
			publication.Title			= x.GetElementValue<string>("Title");
			publication.Subtitle		= x.GetElementValue<string>("Subtitle");
			publication.Author			= x.GetElementValue<string>("Author");
			publication.Volume			= x.GetElementValue<string>("Volume");
			publication.Number			= x.GetElementValue<string>("Number");
			publication.Series			= x.GetElementValue<string>("Series");
			publication.Year			= x.GetElementValue<string>("Year");
			publication.Month			= x.GetElementValue<string>("Month");
			publication.Edition			= x.GetElementValue<string>("Edition");
			publication.Publisher		= x.GetElementValue<string>("Publisher");
			publication.Address			= x.GetElementValue<string>("Address");
			publication.Pagetotal		= x.GetElementValue<string>("Pagetotal");
			publication.Journal			= x.GetElementValue<string>("Journal");
			publication.Pages			= x.GetElementValue<string>("Pages");
			publication.Issue			= x.GetElementValue<string>("Issue");
			publication.Isbn			= x.GetElementValue<string>("Isbn");
			publication.Issn			= x.GetElementValue<string>("Issn");
			publication.Doi				= x.GetElementValue<string>("Doi");
			publication.Language		= x.GetElementValue<string>("Language");
			publication.Note			= x.GetElementValue<string>("Note");
			publication.Url				= x.GetElementValue<string>("Url");
			publication.UrlDate			= x.GetElementValue<string>("UrlDate");
			publication.Abstract		= x.GetElementValue<string>("Abstract");

			XElement xForeginIdentifiers	= x.Element("ForeignIds");

			if (xForeginIdentifiers != null)
			{
				foreach (XElement xItem in xForeginIdentifiers.Elements())
				{
					publication.ForeignIdentifiers.Add(xItem.Name.ToString(), xItem.Value);
				}
			}
			
			return publication;
		}
		#endregion

		#region String representation
		public override string ToString()
		{
			switch (this.PublicationType)
			{
				case PublicationType.Book:
					string result = $"{this.Author}. {this.Title}, {this.Year}";
					if (!String.IsNullOrEmpty(this.Isbn))
					{
						result += $". ISBN {this.Isbn}";
					}

					return result;

				case PublicationType.Article:
					return $"Article: ID = {this.Id}. {this.Author}. {this.Title}, {this.Journal}, {this.Year}:{this.Volume}:{this.Pages}";

				case PublicationType.Unknown:
				default:
					return "Unknown";
			}
		}
		#endregion

		#region Private auxiliary
		private static string Capitalize(string source)
		{
			return source.Substring(0, 1).ToUpper() + source.Substring(1);
		}
		#endregion
	}
}
