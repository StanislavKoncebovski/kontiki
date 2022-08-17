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
		public void CheckingOnline_DefaultbasicUrl_Succeeds()
		{
			HapKontiki kontiki	= new HapKontiki();
			string basicUrl		= kontiki.BaseUrls["Default"];
			bool isOnline		= kontiki.IsOnline(basicUrl);
		}

        public void QueryBooksValidGeneralQueryStringSucceeds()
		{
            HapKontiki kontiki	= new HapKontiki();
			string tokens		= "bellman richard";
			List<Publication> publications = kontiki.QueryBooks(tokens);
			Assert.IsNotNull(publications);
			Assert.That(publications.Count > 0);
		}

        public void QueryBooksInvalidGeneralQueryStringReturnsEmptySet()
		{
            HapKontiki kontiki	= new HapKontiki();
			string tokens		= "^56m";
			List<Publication> publications = kontiki.QueryBooks(tokens);
			Assert.That(publications.Count == 0);
		}

        public void QueryBooksByIsbnValidIsbnSucceeds()
		{
            HapKontiki kontiki	= new HapKontiki();
			string isbn = "9780486432588";
			List<Publication> books = kontiki.QueryBooks(isbn, QueryColumn.ISBN);
			Assert.That(books.Count == 1);
		}

		public void QueryBooksByIsbnInvalidIsbnReturnsEmptySet()
		{
			HapKontiki kontiki	= new HapKontiki();
			string isbn = "9780486432580";
			List<Publication> books = kontiki.QueryBooks(isbn, QueryColumn.ISBN);
			Assert.That(books.Count == 0);
		}

		public void QueryBooksByTagsValidTagsSucceeds()
		{
			HapKontiki kontiki	= new HapKontiki();
			string tags = "mathematics, numerical";
			List<Publication> books = kontiki.QueryBooks(tags, QueryColumn.ISBN);
			Assert.That(books.Count > 0);
		}

		public void QueryBooksByTagsInvalidTagsReturnsEmptySet()
		{
			HapKontiki kontiki	= new HapKontiki();
			string tags = "foxilization";
			List<Publication> books = kontiki.QueryBooks(tags, QueryColumn.ISBN);
			Assert.That(books.Count == 0);
		}
		public void RetrieveBookFormatBibtexValidMd5Succeeds()
		{
			HapKontiki kontiki	= new HapKontiki();
			string md5 = "16D8AEA90AB88BE35C6C8CB7B9335991";
			string bibtex = kontiki.RetrieveBookBibTex(md5);
			Assert.IsNotNull(bibtex);
			Assert.That(bibtex.Length > 0);
		}

		public void RetrieveBookFormatInstanceValidMd5Succeeds()
		{
			HapKontiki kontiki	= new HapKontiki();
			string md5 = "16D8AEA90AB88BE35C6C8CB7B9335991";
			Publication book = kontiki.RetrieveBook(md5);
			Assert.IsNotNull(book);
		}

		public void RetrieveBookInvalidMd5ReturnsNone()
		{
			HapKontiki kontiki	= new HapKontiki();
			string md5 = "16D8AEA90AB88BE35C6C8CB7B9335992";
			string bibtex = kontiki.RetrieveBookBibTex(md5);
			Assert.IsNull(bibtex);
		}

		public void QueryArticlesValidQueryStringSucceeds()
		{
			HapKontiki kontiki	= new HapKontiki();
			string tokens = "bellman richard matrix";
			List<Publication> articles = kontiki.QueryArticles(tokens);
			Assert.That(articles.Count > 0);
		}

		public void QueryArticlesInvalidQueryStringReturnsEmptySet()
		{
			HapKontiki kontiki	= new HapKontiki();
			string tokens = "bellman richard cats";
			List<Publication> articles = kontiki.QueryArticles(tokens);
			Assert.That(articles.Count == 0);
		}

		public void RetrieveArticleFormatBibtexValidDoiSucceeds()
		{
			HapKontiki kontiki	= new HapKontiki();
			string doi = "10.1016/0022-247x(78)90262-7";
			Publication article = kontiki.RetrieveArticle(doi);
			Assert.IsNotNull(article);
		}

		public void RetrieveArticleFormatInstanceValidDoiSucceeds()
		{
			HapKontiki kontiki	= new HapKontiki();
			string doi = "10.1016/0022-247x(78)90262-7";
			string bibtex = kontiki.RetrieveArticleBibTex(doi);
			Assert.IsNotNull(bibtex);
			Assert.That(bibtex.Length > 0);
		}

		public void RetrieveArticleInvalidDoiReturnsEmptySet()
		{
			HapKontiki kontiki	= new HapKontiki();
			string doi = "10.1016/0022-247x(78)90262-8";
			Publication article = kontiki.RetrieveArticle(doi);
			Assert.IsNull(article);
		}
	}
}
