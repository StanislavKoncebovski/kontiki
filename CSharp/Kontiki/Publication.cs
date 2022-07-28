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
using System.Xml.Linq;

namespace Kontiki
{
	/// <summary>
	/// Either a book or an article (so far).
	/// </summary>
	public class Publication
	{
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
			throw new NotImplementedException();
		}

		public static Publication FromBibTeX(string bibtex)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region XML
		public XElement ToXElement()
		{
			throw new NotImplementedException();
		}

		public static Publication FromXElement(XElement x)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
