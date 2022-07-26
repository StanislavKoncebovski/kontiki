import unittest

class KontikiTests(unittest.TestCase):
    def test_query_books_valid_general_query_string_succeeds(self):
        pass

    def test_query_books_invalid_general_query_string_returns_empty_set(self):
        pass

    def test_query_books_by_isbn_valid_isbn_succeeds(self):
        pass

    def test_query_books_by_isbn_invalid_isbn_returns_empty_set(self):
        pass

    def test_query_books_by_tags_valid_tags_succeeds(self):
        pass

    def test_query_books_by_tags_invalid_tags_returns_empty_set(self):
        pass

    def test_retrieve_book_format_dict_valid_md5_succeeds(self):
        pass

    def test_retrieve_book_format_bibtex_valid_md5_succeeds(self):
        pass

    def test_retrieve_book_invalid_md5_returns_none(self):
        pass

    def test_query_articles_valid_query_string_succeeds(self):
        pass

    def test_query_articles_invalid_query_string_returns_empty_set(self):
        pass

    def test_retrieve_article_format_dict_valid_doi_succeeds(self):
        pass

    def test_retrieve_article_format_bibtex_valid_doi_succeeds(self):
        pass

    def test_retrieve_article_invalid_doi_returns_empty_set(self):
        pass