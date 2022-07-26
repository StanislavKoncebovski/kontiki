class Publication:
    pass

class Publication:
    def __init__(self):
        self.publication_type = ""  # supported are: 'book' or 'article'
        self.id = 0                 # Kontiki ID
        self.libgen_id = 0
        self.title = ""
        self.author = ""
        self.volume = ""
        self.series = ""
        self.year = ""
        self.edition = ""
        self.publisher = ""
        self.city = ""
        self.pages = ""
        self.issue = ""
        self.isbn = ""
        self.issn = ""
        self.doi = ""

    def to_bibtex(self) -> str:
        pass

    @classmethod
    def from_bibtex(clsbibtex: str) -> Publication:
        pass