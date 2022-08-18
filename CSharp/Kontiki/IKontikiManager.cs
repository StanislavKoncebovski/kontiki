/***********************************************************************************
* File:         IKontikiManager.cs                                                 *
* Contents:     Interface IKontikiManager                                          *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-18 12:34                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System.Collections.Generic;

namespace Kontiki
{
	public interface IKontikiManager
	{
		#region Properties
		IKontikiConnectionManager ConnectionManager {get;}
		#endregion

		#region Public Functionality

		/// <summary>
		/// Carries out a general query for books using common tokens like title and author(s) name(s).
		/// </summary>
		/// <param name="tokens">The string containing the tokens. The tokens can be divided by space or comma.</param>
		/// <param name="queryColumn">The column to query by.</param>
		/// <returns>A list containing the books found.</returns>
		List<Publication> QueryBooks(string tokens, QueryColumn queryColumn = QueryColumn.Default);

		/// <summary>
		/// Retrieves a book's BibTeX reference by its unique MD5 value.
		/// </summary>
		/// <param name="md5">The MD5 code of the book.</param>
		/// <returns>If found, the book's BibTeX reference value, otherwise null</returns>
		string RetrieveBookBibTex(string md5);

		/// <summary>
		/// Retrieves a book by its unique MD5 value.
		/// </summary>
		/// <param name="md5">The MD5 code of the book.</param>
		/// <returns>If found, the publication value, otherwise null</returns>
		Publication RetrieveBook(string md5);

		/// <summary>
		/// Carries out a general query for articles using common allowed tokens such as title, author(s), and DOI.
		/// </summary>
		/// <param name="tokens">The string containing the tokens. The tokens can be divided by space or comma.</param>
		/// <returns>A list containing the articles found.</returns>
		List<Publication> QueryArticles(string tokens);

		/// <summary>
		/// Retrieves an article's BibTeX referenece by its DOI value.
		/// </summary>
		/// <param name="doi">The DOI value.</param>
		/// <returns>If found, the article's BibTeX reference value, otherwise null.</returns>
		string RetrieveArticleBibTex(string doi);

		/// <summary>
		/// Retrieves an article by its DOI value.
		/// </summary>
		/// <param name="doi">The DOI value.</param>
		/// <returns>If found, the publication value, otherwise null.</returns>
		Publication RetrieveArticle(string doi);
		#endregion
	}
}
