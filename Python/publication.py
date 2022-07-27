from typing import Optional


class Publication:
    pass

def create_bibtex_string(publication: Publication, key: str) -> Optional[str]:
    value = getattr(publication, key)
    if value is None:
        return None
    elif type(value) is str:
        if len(value) > 0:
            delim = "\t" * (3 - ((4 + len(key)) // 5))
            return f"\t{key} ={delim}{{{value}}},\n"
        else:
            return None
    else:
        return None

FIELDS_RESTRICTED = ['md5', 'publication_type']

class Publication:
    def __init__(self, publication_type: str = 'Misc'):
        self.publication_type = publication_type  # presently supported are: 'book' or 'article'
        self.id = 0                 # Kontiki ID
        self.md5 = ""               # LibGen's MD5. the unique identifier of a publication on LibGen
        self.title = ""
        self.subtitle = ""
        self.author = ""
        self.volume = ""
        self.number = ""            # For articles
        self.series = ""
        self.year = ""
        self.month = ""             # For articles
        self.edition = ""
        self.publisher = ""
        self.address  = ""          # A.k.a. location, city
        self.pagetotal = ""         # For books
        self.pages = ""             # For articles
        self.issue = ""
        self.isbn = ""
        self.issn = ""
        self.doi = ""
        self.language = ""
        self.note = ""
        self.url = ""
        self.url_date = ""
        self.abstract = ""
        self.foreign_identifiers = {}   # Secondary and optional foreign ids, probably for a later version.
                                        # Include:
                                        # libgen_id,
                                        # asin: the text's Amazon Standard Identification Number
                                        # udc: the text's Universal Decimal Classification number
                                        # ddc: the text's Dewey Decimal Classification number
                                        # lcc: the text's Library of Congress Classification number


    def to_bibtex(self) -> str:
        '''
        Converts a publication to BibTeX reference.
        :return: The BibTeX reference of the publication.
        '''
        result = f"@book{{{self.publication_type}_{self.id},\n"  # TODO: generate Id from the first author's name and year; otherwise from title or automatically

        for key, value in self.__dict__.items():
            if key in FIELDS_RESTRICTED:
                continue

            line = create_bibtex_string(self, key)
            if line is not None:
                result += line

        result += "}"

        return result

    @classmethod
    def from_bibtex(cls, bibtex: str) -> Optional[Publication]:
        '''
        Creates an instance of Publication from its BibTeX reference.
        :param bibtex: The BibTeX reference.
        :return: The instance of Publication created, if successful, otherwise None.
        '''
        lines = bibtex.strip().split("\n")

        if len(lines) < 3:
            return None

        publication = Publication()

        for line in lines[1:]:
            cells = line.split("=")

            if len(cells) == 2:
                key = cells[0].strip()
                value = cells[1].strip().replace("{", "").replace("},", "")
                setattr(publication, key, value)

        return publication

if __name__ == '__main__':
    publication = Publication('book')
    publication.id = 1001
    publication.title = "Elephant breeding in Canada"
    publication.author = "Arborio, Don"
    publication.isbn = "1234567880"
    publication.year = "2022"
    publication.series = "Animal Adventures"
    publication.edition = "XIII"
    publication.volume = "5"
    publication.publisher = "Microsoft Press"
    publication.address = "Hongkong"

    y = create_bibtex_string(publication, 'title')
    bibtex = publication.to_bibtex()

    print(bibtex)

    pub2 = Publication.from_bibtex(bibtex)

    print(pub2)