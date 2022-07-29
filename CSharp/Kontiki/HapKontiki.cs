/***********************************************************************************
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
using HtmlAgilityPack;

namespace Kontiki
{
	public class HapKontiki : IKontiki
	{
		/// <summary>
		/// Implementation using HtmlAgilityPack
		/// </summary>
		#region Static members
		private static string BASE_URL_BOOK_SEARCH = "http://libgen.rs/search.php";
		private static int DEFAULT_NUMBER_OF_ITEMS = 25;
		#endregion

		#region IKontiki
		/// <param name="tokens"></param>
		/// <param name="queryColumn"></param>
		/// <returns></returns>
		public List<Publication> QueryBooks(string tokens, QueryColumn queryColumn = QueryColumn.Default)
		{
			string requestString = $"{BASE_URL_BOOK_SEARCH}?req={tokens}&res={DEFAULT_NUMBER_OF_ITEMS}&column=def";
			
			string responseString = GetResponse(requestString);

			HtmlDocument doc = new HtmlDocument();
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

		public Publication RetrieveBook(string md5)
		{
			throw new NotImplementedException();
		}

		public List<Publication> QueryArticles(string tokens)
		{
			throw new NotImplementedException();
		}

		public Publication RetrieveArticle(string doi)
		{
			throw new NotImplementedException();
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
		#endregion
	}
}
