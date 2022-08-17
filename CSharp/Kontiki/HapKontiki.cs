﻿/***********************************************************************************
* File:         HapKontiki.cs                                                      *
* Contents:     Class HapKontiki                                                   *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-07-29 10:31                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
	
namespace Kontiki
{
	public class HapKontiki : IKontiki
	{
		/// <summary>
		/// Implementation using HtmlAgilityPack
		/// </summary>
		#region Static members
		private static string	BASE_URL_BOOK_SEARCH	= "https://libgen.rs/search.php";
		private static string	BASE_URL_BOOK_BIBTEX	= "http://libgen.rs/book/bibtex.php";
		private static string	BASE_URL_ARTICLE_SEARCH	= "http://libgen.rs/scimag";
		private static int		DEFAULT_NUMBER_OF_ITEMS = 25;
		#endregion

		#region Properties
		/// <summary>
		/// Dictionary of LibGen's base URLs.
		/// Key: the extension (or its replacements) like "rs", "is", etc.
		/// Value: The base URL for that extension, like "https://libgen.rs" for "rs.
		/// Sources: https://ardroiding.com/libgen-proxy-and-mirror-sites/
		/// </summary>
		public Dictionary<string, string>	BaseUrls {get;internal set;} = new Dictionary<string, string>()
		{
			{"Default", "http://libgen.rs/"},
			{"Proxy01", "https://freeanimesonline.com/proxify.php?proxy=ZnJlZWFuaW1lc29ubGluZS5jb20=&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
			{"Proxy02",	"https://sitenable.info/proxify.php?proxy=c2l0ZW5hYmxlLmluZm8=&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
			{"Proxy03", "https://siteget.net/proxify.php?proxy=c2l0ZWdldC5uZXQ=&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
			{"Proxy04", "https://freeproxy.io/proxify.php?proxy=ZnJlZXByb3h5Lmlv&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
			{"Proxy05", "https://sitenable.co/proxify.php?proxy=c2l0ZW5hYmxlLmNv&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
			{"Proxy06", "https://sitenable.ch/proxify.php?proxy=c2l0ZW5hYmxlLmNo&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
			{"Proxy07", "https://sitenable.pw/proxify.php?proxy=c2l0ZW5hYmxlLnB3&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
		};

		/// <summary>
		/// Gets or sets the working Base URL key.
		/// </summary>
		public string WorkingUrlKey {get;set;}

		/// <summary>
		/// Gets the current base URL for book search.
		/// </summary>
		public string BaseBookSearchUrl {get;}

		/// <summary>
		/// Gets the current base URL for obtaining the BibTeX reference.
		/// </summary>
		public string BaseBibtexUrl {get;}

		/// <summary>
		/// Gets the current base URL for article search.
		/// </summary>
		public string BaseArticleSearchUrl {get;}
		#endregion

		#region IKontiki
		public bool IsOnline(string url)
		{
			WebRequest request = HttpWebRequest.Create(url);

			try
			{
				using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
				{
					return response.StatusCode == HttpStatusCode.OK;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Carries out a general query for books using common tokens like title and author(s) name(s).
		/// </summary>
		/// <param name="tokens">The string containing the tokens. The tokens can be divided by space or comma.</param>
		/// <param name="queryColumn">The column to query by.</param>
		/// <returns>A list containing the books found.</returns>
		public List<Publication> QueryBooks(string tokens, QueryColumn queryColumn = QueryColumn.Default)
		{
			string column			= "def";

			switch (queryColumn)
			{
				case QueryColumn.Author:
					column = "author";
					break;

				case QueryColumn.Title:
					column = "title";
					break;

				case QueryColumn.ISBN:
					column = "identifier";
					break;

				case QueryColumn.Tags:
					column = "tags";
					break;

				case QueryColumn.Default:
				default:
					break;
			}

			string requestString	= $"{BASE_URL_BOOK_SEARCH}?req={tokens}&res={DEFAULT_NUMBER_OF_ITEMS}&column={column}";
			
			string responseString	= GetResponse(requestString);

			if (responseString == null)
			{
				return null;
			}

			HtmlDocument doc		= new HtmlDocument();
			doc.LoadHtml(responseString);

			HtmlNode[] tables = doc.DocumentNode.SelectNodes("//table").ToArray();
			HtmlNode table = tables[2];

			HtmlNodeCollection tableRows = table.SelectNodes("tr");

			List<Publication> publications = new List<Publication>();

			foreach (HtmlNode tableRow in tableRows.Skip(1))
			{
				HtmlNode[] columns		= tableRow.SelectNodes("td").ToArray();

				Publication publication = new Publication(PublicationType.Book);
				publication.Author		= columns[1].InnerText;

				HtmlNode column2		= columns[2];

				HtmlNode[] links		= column2.SelectNodes("a").ToArray();

				if (links.Length == 2)
				{
					publication.Series		= links[0].InnerText;

					publication.Title		= links[1].ChildNodes[0].InnerText;
					publication.Edition		= GetSafeNodeValue(links[0], 1);
					publication.Isbn		= GetSafeNodeValue(links[0], 4);
				}
				else if (links.Length == 1)
				{
					publication.Title		= links[0].ChildNodes[0].InnerText;
					publication.Edition		= GetSafeNodeValue(links[0], 1);
					publication.Isbn		= GetSafeNodeValue(links[0], 4);
				}
				else
				{

				}

				publication.Publisher	= columns[3].InnerText;
				publication.Year		= columns[4].InnerText;
				publication.Pagetotal	= columns[5].InnerText;
				publication.Language	= columns[6].InnerText;

				string md5				= ExtractMd5(columns[9]);

				publication.Md5			= md5;

				publications.Add(publication);
			}

			return publications;
		}

		/// <summary>
		/// Retrieves a book's BibTeX reference by its unique MD5 value.
		/// </summary>
		/// <param name="md5">The MD5 code of the book.</param>
		/// <returns>If found, the book's BibTeX reference value, otherwise null</returns>
		public string RetrieveBookBibTex(string md5)
		{
			try
			{
				string requestString	= $"{BASE_URL_BOOK_BIBTEX}?md5={md5}";
				string responseString	= GetResponse(requestString);
				HtmlDocument doc		= new HtmlDocument();
				doc.LoadHtml(responseString);

				string bibtex			= doc.DocumentNode.SelectSingleNode("//textarea").InnerText;
				return bibtex.Trim();
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Retrieves a book by its unique MD5 value.
		/// </summary>
		/// <param name="md5">The MD5 code of the book.</param>
		/// <returns>If found, the publication value, otherwise null</returns>
		public Publication RetrieveBook(string md5)
		{
			string bibtex = this.RetrieveBookBibTex(md5);

			if (!String.IsNullOrEmpty(bibtex))
			{
				try
				{
					return Publication.FromBibTeX(bibtex);
				}
				catch
				{
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// Carries out a general query for articles using common allowed tokens such as title, author(s), and DOI.
		/// </summary>
		/// <param name="tokens">The string containing the tokens. The tokens can be divided by space or comma.</param>
		/// <returns>A list containing the articles found.</returns>
		public List<Publication> QueryArticles(string tokens)
		{
			string requestString	= $"{BASE_URL_ARTICLE_SEARCH}/?q={tokens}";
			string responseString	= GetResponse(requestString);
			HtmlDocument doc		= new HtmlDocument();
			doc.LoadHtml(responseString);

			HtmlNode table = doc.DocumentNode.SelectSingleNode("//table");

			HtmlNode tableBody = table.SelectSingleNode("tbody");

			List<Publication> publications = new List<Publication>();

			foreach (HtmlNode tableRow in tableBody.SelectNodes("tr"))
			{
				Publication publication = new Publication(PublicationType.Article);

				HtmlNode[] columns = tableRow.SelectNodes("td").ToArray();

				publication.Author = columns[0].InnerText;

				HtmlNode[] paragraphs = columns[1].SelectNodes("p").ToArray();

				if (paragraphs.Length == 2)
				{
					publication.Title = paragraphs[0].InnerText;
					publication.Doi = paragraphs[1].InnerText.Replace("DOI:", "").Trim();
				}

				try
				{
					paragraphs = columns[2].SelectNodes("p").ToArray();

					if (paragraphs.Length == 2)
					{
						publication.Journal = paragraphs[0].SelectSingleNode("a").InnerText;

						string[] article_data = ExtractArticleData(paragraphs[1].InnerText);

						if (article_data != null)
						{
							publication.Volume = article_data[0];
							publication.Issue = article_data[1];
							publication.Year = article_data[2];
						}
					}
				}
				catch {}
                
                publications.Add(publication);
			}

			return publications;
		}

		/// <summary>
		/// Retrieves an article's BibTeX referenece by its DOI value.
		/// </summary>
		/// <param name="doi">The DOI value.</param>
		/// <returns>If found, the article's BibTeX reference value, otherwise null.</returns>
		public string RetrieveArticleBibTex(string doi)
		{
			string requestString	= $"{BASE_URL_ARTICLE_SEARCH}/{doi}/bibtex";
			string responseString	= GetResponse(requestString);
			
			return responseString;
		}

		/// <summary>
		/// Retrieves an article by its DOI value.
		/// </summary>
		/// <param name="doi">The DOI value.</param>
		/// <returns>If found, the publication value, otherwise null.</returns>
		public Publication RetrieveArticle(string doi)
		{
			string bibtex = this.RetrieveArticleBibTex(doi);

			if (!String.IsNullOrEmpty(bibtex))
			{
				try
				{
					return Publication.FromBibTeX(bibtex);
				}
				catch
				{
					return null;
				}
			}
			else
			{
				return null;
			}
		}
		#endregion

		#region Private Auxiliary
		/// <summary>
		/// Gets a HTML respose to a request.
		/// </summary>
		/// <param name="requestString">The request string (URL).</param>
		/// <returns>The request string, if successful, otherwise null.</returns>
		private static string GetResponse(string requestString)
		{
			WebRequest request = WebRequest.Create(requestString);

			try
			{
				using (WebResponse response = request.GetResponse())
				{
					using (Stream stream = response.GetResponseStream())
					{
						StreamReader reader = new StreamReader(stream, Encoding.UTF8);
						return reader.ReadToEnd();
					}
				}
			}
			catch (WebException)
			{
				return null;
			}
		}

		/// <summary>
		/// Extracts MD5 out of a LibGen HTML node.
		/// </summary>
		/// <param name="node">The node to extract from.</param>
		/// <returns>The MD5 value, if successful, otherwise null.</returns>
		private static string ExtractMd5(HtmlNode node)
		{
			try
			{
				HtmlNode a		= node.SelectSingleNode("a");
				string value	= a.Attributes[0].Value;
				return value.Substring(value.Length - 32, 32);
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Gets a safe string value of a node's child node.
		/// </summary>
		/// <param name="node">The base node.</param>
		/// <param name="index">The index of the child node.</param>
		/// <returns>The inner HTML of the child node, if it exists, otherwise an empty string.</returns>
		private static string GetSafeNodeValue(HtmlNode node, int index)
		{
			try
			{
				return node.ChildNodes[index].InnerText;
			}
			catch
			{
				return "";
			}
		}

		private static string[] ExtractArticleData(string source)
		{
			var matches = Regex.Matches(source, @"\d+");

			if (matches.Count == 3)
			{
				return new string[] {matches[0].Value, matches[1].Value, matches[2].Value};
			}
			else
			{
				return null;
			}
		}
		#endregion
	}
}
