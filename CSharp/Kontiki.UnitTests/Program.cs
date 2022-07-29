using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontiki.UnitTests
{
	class Program
	{
		static void Main(string[] args)
		{
			Publication publication = new Publication();
			publication.Abstract = "Jxuros metis el gxin mi scias metrojn por knabon lernejon sed ia de ni la sxancon estas vivmaniero el homoj";
			publication.Address	= "Kyoto";
			publication.Author	= "Don Arborio";
			publication.Doi = "123.456.789";
			publication.Edition = "3rd ed.";
			publication.Id	= 1001;
			publication.Isbn = "9781234567890";
			publication.Issn = "12345678";
			publication.Issue = "12";
			publication.Journal = "In noi dea giudicio giudice il";
			publication.Language = "Ido";
			publication.Md5 = "ABCD123456KLMN";
			publication.Month = "october";
			publication.Note = "Or tempter flown nevermore and all napping friends violet relevancy the marvelled raven off his the tossed angels the one";
			publication.Number	= "12";
			publication.Pages = "123-456";
			publication.Pagetotal = "789";
			publication.PublicationType = PublicationType.Article;
			publication.Publisher = "Feltrinelli";
			publication.Series = "Labore elitr possim ea";
			publication.Subtitle = "Toujours majesté c'est ou faite divines ce que";
			publication.Title	= "Bateau au coup les faisait fois";
			publication.Url = "www.aaa.bbb.com";
			publication.UrlDate = DateTime.Now.ToString("yyyy-MM-dd");
			publication.Volume = "17";
			publication.Year = "2005";

			string bibtex = publication.ToBibTeX();

			Publication p2 = Publication.FromBibTeX(bibtex);

			var kontiki = new HapKontiki();
			var books = kontiki.QueryBooks("9780898713992", QueryColumn.ISBN);

			foreach (var book in books)
			{
				Console.WriteLine(book.ToBibTeX());
			}

			string md5 = "16d8aea90ab88be35c6c8cb7b9335991";

			Publication p3 = kontiki.RetrieveBook(md5);


			string tokens = "Bellman+Matrix";

			var articles = kontiki.QueryArticles(tokens);

			Console.WriteLine("==== ARTICLES ====\n");

			foreach (var article in articles)
			{
				Console.WriteLine(article.ToBibTeX());
			}

			Console.ReadLine();
		}
	}
}
