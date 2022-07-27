from typing import Union, Optional
import requests
from bs4 import BeautifulSoup as bs
from itertools import islice
from publication import Publication


def bibtex_to_dictionary(bibtex: str) -> dict[str, str]:
    '''
    Converts BibTeX into dictionary.
    :param bibtex:
    :return:
    '''

    lines = bibtex.strip().split("\n")
    if len(lines) < 2:
        return {}

    result = {}
    for line in lines[1:]:
        cells = line.split("=")

        if len(cells) == 2:
            key = cells[0].strip()
            value = cells[1].strip().replace("{", "").replace("},", "")

            result[key] = value

    return result

class Kontiki:
    '''
    Contains functions to query and retrieve books and articles from a LibGen server.
    '''
    BASE_URL_BOOK_SEARCH = "http://libgen.rs/search.php"
    BASE_URL_BOOK_RETRIEVE = "http://libgen.rs/book/index.php"
    BASE_URL_BOOK_BIBTEX = "http://libgen.rs/book/bibtex.php"

    '''
    The number of items to return in a book query
    '''
    DEFAULT_NUMBER_OF_ITEMS = 25

    def query_books(self, tokens: str) -> list[Publication]:
        '''
        Carries out a general query for books using common tokens like title and author(s) name(s).
        :param tokens: The string containing the tokens. The tokens can be divided by space or comma.
        :return: A pandas dataframe containing the books found. The columns of the dataframe are the fields of the
                 output, such as MD5, Title, Author, etc.
        '''
        request = f"{Kontiki.BASE_URL_BOOK_SEARCH}?req={tokens}&res={Kontiki.DEFAULT_NUMBER_OF_ITEMS}&column=def"
        response_text = requests.get(request).text
        soup = bs(response_text, 'html.parser')
        tables = soup.find_all("table")

        table = tables[2]   # it is always table 2

        table_rows = table.find_all("tr")

        publications = []
        for table_row in islice(table_rows, 1, None):
            columns = table_row.find_all("td")
            publication = Publication('book')
            publication.foreign_identifiers['libgen_id'] = columns[0].text
            publication.author = columns[1].text
            publication.title = columns[2].text
            publication.publisher = columns[3].text
            publication.year = columns[4].text
            publication.pagetotal = columns[5].text
            publication.language = columns[6].text

            publication.md5 = columns[9].find("a")['href'][-32:]

            publications.append(publication)

        return publications

    def query_books_by_isbn(self, isbn: str) -> Optional[Publication]:
        '''
        Carries out a query for a book by ISBN.
        :param isbn: The ISBN string. Can contain more than one ISBN (e.g. the 10-digit and the 13-digit ISBN), divided
                     by a space or comma.
        :return: A pandas dataframe with either one row (if the book was found) or empty (no book found).
        '''
        pass

    def query_books_by_tags(self, tags: str) -> list[Publication]:
        '''
        Carries out a query for books by tags.
        :param tags: The tags (e.g. "mathematics, algebra") divided by a space or comma.
        :return:  A pandas dataframe containing the books found.
        '''
        pass

    def retrieve_book(self, md5: str, format: str = 'bibtex') -> Union[Publication, str, None]:
        '''
        Retrieves a book by its unique MD5 value.
        :param md5: The MD5 code of the book.
        :param format: Defines the format of the output. If it is 'dict' (default) the result is a dictionary containing
                       the fields, such as MD5, Title, Author, etc.
                       If it is 'bibtex' the result is a BibTeX reference of the book.
        :return: If found, the dictionary of the book's fields or its BibTeX reference,
                 depending on the output format defined. None, if not found.
        '''
        request = f"{Kontiki.BASE_URL_BOOK_BIBTEX}?md5={md5}"
        response_text = requests.get(request).text
        soup = bs(response_text, "html.parser")
        bibtex = soup.find("textarea").text

        if format == 'bibtex':
            return bibtex
        elif format == 'instance':
            return Publication.from_bibtex(bibtex)
        else:
            return None

    def query_articles(self, tokens: str) -> list[Publication]:
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

if __name__ == '__main__':
    kontiki = Kontiki()
    tokens = "bellman richard numerical"
    publications = kontiki.query_books(tokens)

    for p in publications:
        print(p.to_bibtex())

    print("===================")

    md5 = "6AA7F5356BEA02FAC07BC63132B98F00"

    publication = kontiki.retrieve_book(md5)

    print(publication)