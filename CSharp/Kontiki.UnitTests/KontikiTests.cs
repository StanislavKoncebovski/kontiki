/***********************************************************************************
* File:         KontikiTests.cs                                                    *
* Contents:     Class KontikiTests                                                 *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-08 16:20                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Kontiki.UnitTests
{
	[TestFixture]
	public class KontikiTests
	{
		[Test]
		public void QueryBooksValidGeneralQueryStringSucceeds()
		{
           HapKontikiManager kontiki = PrepareKontikiManager();

			if (kontiki.ConnectionManager.WorkingConnection != null)
			{
				string tokens = "bellman richard";
				List<Publication> publications = kontiki.QueryBooks(tokens);
				Assert.IsNotNull(publications);
				Assert.That(publications.Count > 0);
			}
		}

		[Test]
        public void QueryBooksInvalidGeneralQueryStringReturnsEmptySet()
		{
            HapKontikiManager kontiki = PrepareKontikiManager();

			if (kontiki.ConnectionManager.WorkingConnection != null)
			{
				string tokens		= "^56m";
				List<Publication> publications = kontiki.QueryBooks(tokens);
				Assert.That(publications.Count == 0);
			}
		}

		[Test]
        public void QueryBooksByIsbnValidIsbnSucceeds()
		{
            HapKontikiManager kontiki = PrepareKontikiManager();
			string isbn = "9780486432588";
			List<Publication> books = kontiki.QueryBooks(isbn, QueryColumn.ISBN);
			Assert.That(books.Count == 1);
		}

		[Test]
		public void QueryBooksByIsbnInvalidIsbnReturnsEmptySet()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string isbn = "9780486432580";
			List<Publication> books = kontiki.QueryBooks(isbn, QueryColumn.ISBN);
			Assert.That(books.Count == 0);
		}

		[Test]
		public void QueryBooksByTagsValidTagsSucceeds()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string tags = "mathematics, numerical";
			List<Publication> books = kontiki.QueryBooks(tags, QueryColumn.Tags);
			Assert.That(books.Count > 0);
		}

		[Test]
		public void QueryBooksByTagsInvalidTagsReturnsEmptySet()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string tags = "foxilization";
			List<Publication> books = kontiki.QueryBooks(tags, QueryColumn.Tags);
			Assert.That(books.Count == 0);
		}

		[Test]
		public void RetrieveBookFormatBibtexValidMd5Succeeds()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string md5 = "16D8AEA90AB88BE35C6C8CB7B9335991";
			string bibtex = kontiki.RetrieveBookBibTex(md5);
			Assert.IsNotNull(bibtex);
			Assert.That(bibtex.Length > 0);
		}

		[Test]
		public void RetrieveBookFormatInstanceValidMd5Succeeds()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string md5 = "16D8AEA90AB88BE35C6C8CB7B9335991";
			Publication book = kontiki.RetrieveBook(md5);
			Assert.IsNotNull(book);
		}

		[Test]
		public void RetrieveBookInvalidMd5ReturnsNone()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string md5 = "16D8AEA90AB88BE35C6C8CB7B9335992";
			string bibtex = kontiki.RetrieveBookBibTex(md5);
			Assert.IsNull(bibtex);
		}

		[Test]
		public void QueryArticlesValidQueryStringSucceeds()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string tokens = "bellman richard matrix";
			List<Publication> articles = kontiki.QueryArticles(tokens);
			Assert.That(articles.Count > 0);
		}

		[Test]
		public void QueryArticlesInvalidQueryStringReturnsEmptySet()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string tokens = "bellman richard cats";
			List<Publication> articles = kontiki.QueryArticles(tokens);
			Assert.That(articles.Count == 0);
		}

		[Test]
		public void RetrieveArticleFormatBibtexValidDoiSucceeds()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string doi = "10.1016/0022-247x(78)90262-7";
			Publication article = kontiki.RetrieveArticle(doi);
			Assert.IsNotNull(article);
		}

		[Test]
		public void RetrieveArticleFormatInstanceValidDoiSucceeds()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string doi = "10.1016/0022-247x(78)90262-7";
			string bibtex = kontiki.RetrieveArticleBibTex(doi);
			Assert.IsNotNull(bibtex);
			Assert.That(bibtex.Length > 0);
		}

		[Test]
		public void RetrieveArticleInvalidDoiReturnsEmptySet()
		{
			HapKontikiManager kontiki = PrepareKontikiManager();
			string doi = "10.1016/0022-247x(78)90262-8";
			Publication article = kontiki.RetrieveArticle(doi);
			Assert.IsNull(article);
		}

		#region Private Auxiliary
		private static HapKontikiManager PrepareKontikiManager(string connectionName = "default")
		{
			HapKontikiManager kontiki = new HapKontikiManager();
			string connectionFileName = "kontiki_connections.xml";
			kontiki.ConnectionManager.Load(connectionFileName);
			KontikiConnection connection = kontiki.ConnectionManager.Connections[connectionName];
			kontiki.ConnectionManager.TestConnection(connection);

			return kontiki;
		}
		#endregion
	}
}
