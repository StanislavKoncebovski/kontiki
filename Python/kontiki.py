from typing import Union
import pandas as pd

class Kontiki:
    '''
    Contains functions to query and retrieve books and articles from a LibGen server.
    '''
    def query_books(self, tokens: str) -> pd.DataFrame:
        '''
        Carries out a general query for books using common tokens like title and author(s) name(s).
        :param tokens: The string containing the tokens. The tokens can be divided by space or comma.
        :return: A pandas dataframe containing the books found. The columns of the dataframe are the fields of the
                 output, such as MD5, Title, Author, etc.
        '''
        pass

    def query_books_by_isbn(self, isbn: str) -> pd.DataFrame:
        '''
        Carries out a query for a book by ISBN.
        :param isbn: The ISBN string. Can contain more than one ISBN (e.g. the 10-digit and the 13-digit ISBN), divided
                     by a space or comma.
        :return: A pandas dataframe with either one row (if the book was found) or empty (no book found).
        '''
        pass

    def query_books_by_tags(self, tags: str) -> pd.DataFrame:
        '''
        Carries out a query for books by tags.
        :param tags: The tags (e.g. "mathematics, algebra") divided by a space or comma.
        :return:  A pandas dataframe containing the books found.
        '''
        pass

    def retrieve_book(self, md5: str, format: str = 'dict') -> Union[dict[str, str], str, None]:
        '''
        Retrieves a book by its unique MD5 value.
        :param md5: The MD5 code of the book.
        :param format: Defines the format of the output. If it is 'dict' (default) the result is a dictionary containing
                       the fields, such as MD5, Title, Author, etc.
                       If it is 'bibtex' the result is a BibTeX reference of the book.
        :return: If found, the dictionary of the book's fields or its BibTeX reference,
                 depending on the output format defined. None, if not found.
        '''
        pass

    def query_articles(self, tokens: str) -> pd.DataFrame:
        '''
        Carries out a general query for articles using common allowed tokens such as title, author(s), and DOI.
        :param tokens: The string containing the tokens. The tokens can be divided by space or comma.
        :return: A pandas dataframe containing the articles found. The columns of the dataframe are the fields of the
                 output, such as MD5, Title, Author, DOI, etc.
        '''
        pass

    def retrieve_article(self, doi: str, format: str = 'dict') -> Union[dict[str, str], str, None]:
        '''
        Retrieves an article by its DOI value.
        :param doi: The DOI value.
        :param format: Defines the format of the output. If it is 'dict' (default) the result is a dictionary containing
                       the fields, such as MD5, Title, Author, DOI, etc.
                       If it is 'bibtex' the result is a BibTeX reference of the article.
        :return: If found, the dictionary of the article's fields or its BibTeX reference,
                 depending on the output format defined. None, if not found.
        '''
        pass
