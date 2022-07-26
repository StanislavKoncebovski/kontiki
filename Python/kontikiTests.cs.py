import unittest
import pandas as pd

from kontiki import Kontiki


class TestKontiki(unittest.TestCase):
    def test_query_books_valid_general_query_string_succeeds(self):
        kontiki = Kontiki()
        tokens = "bellman richard"
        df: pd.DataFrame = kontiki.query_books(tokens)
        self.assertTrue(df.shape[0] > 0)    # df has rows

    def test_query_books_invalid_general_query_string_returns_empty_set(self):
        kontiki = Kontiki()
        tokens = "^56m"
        df: pd.DataFrame = kontiki.query_books(tokens)
        self.assertTrue(df.shape[0] == 0)  # df is empty

    def test_query_books_by_isbn_valid_isbn_succeeds(self):
        kontiki = Kontiki()
        isbn = "9780486432588"
        df: pd.DataFrame = kontiki.query_books_by_isbn(isbn)
        self.assertTrue(df.shape[0] == 1)  # df contains exactly one row

    def test_query_books_by_isbn_invalid_isbn_returns_empty_set(self):
        kontiki = Kontiki()
        isbn = "9780486432589"
        df: pd.DataFrame = kontiki.query_books_by_isbn(isbn)
        self.assertTrue(df.shape[0] == 0)  # df is empty

    def test_query_books_by_tags_valid_tags_succeeds(self):
        kontiki = Kontiki()
        tags = "mathematics, numerical"
        df: pd.DataFrame = kontiki.query_books_by_tags(tags)
        self.assertTrue(df.shape[0] > 0)  # df is non-empty

    def test_query_books_by_tags_invalid_tags_returns_empty_set(self):
        kontiki = Kontiki()
        tags = "foxilization"
        df: pd.DataFrame = kontiki.query_books_by_tags(tags)
        self.assertTrue(df.shape[0] == 0)  # df is empty

    def test_retrieve_book_format_dict_valid_md5_succeeds(self):
        kontiki = Kontiki()
        md5 = "16D8AEA90AB88BE35C6C8CB7B9335991"
        book = kontiki.retrieve_book(md5)
        self.assertTrue(book is not None)
        self.assertTrue(book is dict[str,str])

    def test_retrieve_book_format_bibtex_valid_md5_succeeds(self):
        kontiki = Kontiki()
        md5 = "16D8AEA90AB88BE35C6C8CB7B9335991"
        bibtex = kontiki.retrieve_book(md5, 'bibtex')
        self.assertTrue(bibtex is str)

    def test_retrieve_book_invalid_md5_returns_none(self):
        kontiki = Kontiki()
        md5 = "16D8AEA90AB88BE35C6C8CB7B9335992"
        book = kontiki.retrieve_book(md5)
        self.assertTrue(book is None)

    def test_query_articles_valid_query_string_succeeds(self):
        kontiki = Kontiki()
        tokens = "bellman richard matrix"
        df: pd.DataFrame = kontiki.query_articles(tokens)
        self.assertTrue(df.shape[0] > 0)  # df is non-empty

    def test_query_articles_invalid_query_string_returns_empty_set(self):
        kontiki = Kontiki()
        tokens = "bellman richard cats"
        df: pd.DataFrame = kontiki.query_articles(tokens)
        self.assertTrue(df.shape[0] == 0)  # df is empty

    def test_retrieve_article_format_dict_valid_doi_succeeds(self):
        kontiki = Kontiki()
        doi = "10.1016/0022-247x(78)90262-7"
        article = kontiki.retrieve_article(doi)
        self.assertTrue(article is not None)
        self.assertTrue(article is dict[str, str])

    def test_retrieve_article_format_bibtex_valid_doi_succeeds(self):
        kontiki = Kontiki()
        doi = "10.1016/0022-247x(78)90262-7"
        bibtex = kontiki.retrieve_article(doi, 'bibtex')
        self.assertTrue(bibtex is not None)
        self.assertTrue(bibtex is str)

    def test_retrieve_article_invalid_doi_returns_empty_set(self):
        kontiki = Kontiki()
        doi = "10.1016/0022-247x(78)90262-8"
        article = kontiki.retrieve_article(doi)
        self.assertTrue(article is None)

if __name__ == '__main__':
    unittest.main()