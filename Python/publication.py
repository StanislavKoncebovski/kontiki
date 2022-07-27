class Publication:
    pass

def create_bibtex_string(publication: Publication, key: str) -> str:
    x = getattr(publication, key)
    if x is not None:
        return f"\t{key} =\t\t{{{x}}},\n"
    else:
        return "***"


class Publication:
    def __init__(self):
        self.publication_type = ""  # supported are: 'book' or 'article'
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
        result = f"@book{{book_{self.id},\n"                    # TODO: generate Id from the first author's name and year; otherwise from title or automatically
        result += f"\ttitle =\t\t{{{self.title}}},\n"
        result += f"\tauthor =\t{{{self.author}}},\n"
        result += f"\tpublisher =\t{{{self.publisher}}},\n"
        result += f"\tisbn =\t\t{{{self.isbn}}},\n"
        result += f"\tyear =\t\t{{{self.year}}},\n"
        result += f"\tseries =\t{{{self.series}}},\n"
        result += f"\tedition =\t{{{self.edition}}},\n"
        result += f"\tvolume =\t{{{self.volume}}}\n"

        result += "}}"

        return result

    @classmethod
    def from_bibtex(clsbibtex: str) -> Publication:
        pass

'''
@book{book:71684,
   title =     {Introduction to matrix analysis},
   author =    {Richard Bellman},
   publisher = {Society for Industrial and Applied Mathematics},
   isbn =      {9780898713992,0898713994},
   year =      {1987},
   series =    {Classics in applied mathematics 19},
   edition =   {2nd ed},
   volume =    {},
   url =       {http://gen.lib.rus.ec/book/index.php?md5=81c8666b0e361c5cd1203f4c4d35fb2a}
}
'''

if __name__ == '__main__':
    publication = Publication()
    publication.id = 1001
    publication.title = "Elephant breeding in Canada"
    publication.author = "Arborio, Don"
    publication.isbn = "1234567880"
    publication.year = "2022"
    publication.series = "Animal Adventures"
    publication.edition = "XIII"
    publication.volume = "5"
    publication.publisher = "Microsoft Press"
    publication.city = "Hongkong"

    y = create_bibtex_string(publication, 'title')
    bibtex = publication.to_bibtex()

    print(bibtex)