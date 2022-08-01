import unittest
import pandas as pd

from kontiki import Kontiki
from publication import Publication


class TestKontiki(unittest.TestCase):
    def test_query_books_valid_general_query_string_succeeds(self):
        kontiki = Kontiki()
        tokens = "bellman richard"
        publications = kontiki.query_books(tokens)
        self.assertTrue(len(publications) > 0)    #  len(publications)

    def test_query_books_invalid_general_query_string_returns_empty_set(self):
        kontiki = Kontiki()
        tokens = "^56m"
        publications = kontiki.query_books(tokens)
        self.assertTrue(len(publications) == 0)  # no publications

    def test_query_books_by_isbn_valid_isbn_succeeds(self):
        kontiki = Kontiki()
        isbn = "9780486432588"
        publication = kontiki.query_books_by_isbn(isbn)
        self.assertIsNotNone(publication)  #  the publication is valid

    def test_query_books_by_isbn_invalid_isbn_returns_empty_set(self):
        kontiki = Kontiki()
        isbn = "9780486432589"
        publication = kontiki.query_books_by_isbn(isbn)
        self.assertIsNone(publication)  # the publication is invalid

    def test_query_books_by_tags_valid_tags_succeeds(self):
        kontiki = Kontiki()
        tags = "mathematics, numerical"
        publications = kontiki.query_books_by_tags(tags)
        self.assertTrue(len(publications) > 0)  # there are publications

    def test_query_books_by_tags_invalid_tags_returns_empty_set(self):
        kontiki = Kontiki()
        tags = "foxilization"
        publications = kontiki.query_books_by_tags(tags)
        self.assertTrue(len(publications) == 0)  # there are no such publications

    def test_retrieve_book_format_bibtex_valid_md5_succeeds(self):
        kontiki = Kontiki()
        md5 = "16D8AEA90AB88BE35C6C8CB7B9335991"
        bibtex = kontiki.retrieve_book(md5)
        self.assertTrue(bibtex is not None)
        self.assertTrue(type(bibtex) is str)

    def test_retrieve_book_format_instance_valid_md5_succeeds(self):
        kontiki = Kontiki()
        md5 = "16D8AEA90AB88BE35C6C8CB7B9335991"
        book = kontiki.retrieve_book(md5, 'instance')
        self.assertTrue(book is not None)
        self.assertTrue(type(book) is Publication)

    def test_retrieve_book_invalid_md5_returns_none(self):
        kontiki = Kontiki()
        md5 = "16D8AEA90AB88BE35C6C8CB7B9335992"
        book = kontiki.retrieve_book(md5)
        self.assertTrue(book is None)

    def test_query_articles_valid_query_string_succeeds(self):
        kontiki = Kontiki()
        tokens = "bellman richard matrix"
        publications = kontiki.query_articles(tokens)
        self.assertTrue(len(publications) > 0)  # df is non-empty

    def test_query_articles_invalid_query_string_returns_empty_set(self):
        kontiki = Kontiki()
        tokens = "bellman richard cats"
        publications = kontiki.query_articles(tokens)
        self.assertTrue(len(publications) == 0)  #  is empty

    def test_retrieve_article_format_bibtex_valid_doi_succeeds(self):
        kontiki = Kontiki()
        doi = "10.1016/0022-247x(78)90262-7"
        bibtex = kontiki.retrieve_article(doi)
        self.assertTrue(bibtex is not None)
        self.assertTrue(type(bibtex) is str)

    def test_retrieve_article_format_instance_valid_doi_succeeds(self):
        kontiki = Kontiki()
        doi = "10.1016/0022-247x(78)90262-7"
        article = kontiki.retrieve_article(doi, 'instance')
        self.assertTrue(article is not None)
        self.assertTrue(type(article) is Publication)

    def test_retrieve_article_invalid_doi_returns_empty_set(self):
        kontiki = Kontiki()
        doi = "10.1016/0022-247x(78)90262-8"
        article = kontiki.retrieve_article(doi)
        self.assertTrue(article is None)

if __name__ == '__main__':
    unittest.main()