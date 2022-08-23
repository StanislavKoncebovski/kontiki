using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Kontiki.Collection;
using NUnit.Framework;

namespace Kontiki.UnitTests
{
	[TestFixture]
	public class KontikiCollectionTests
	{
		[Test]
		public void CollectionNodeToXmlAndBackAgain_Succeeds()
		{
			CollectionNode root = new CollectionNode("Root", "This is the root");
			CollectionNode folder1 = new CollectionNode("Folder1", "This is folder 1 under root");
			root.Children.Add(folder1);

			CollectionNode folder2 = new CollectionNode("Folder2", "This is folder 2 under root");
			root.Children.Add(folder2);

			CollectionNode folder3 = new CollectionNode("Folder3", "This is folder 3 under folder 1");
			folder1.Children.Add(folder3);

			Publication book1 = new Publication(PublicationType.Book);
			book1.Author = "Tim Pfennig";
			book1.Title = "How to breed elephants in a small flat.";
			book1.Year = "2020";

			CollectionNode cnBook1 = new CollectionNode(book1);
			folder1.Children.Add(cnBook1);

			Publication article1 = new Publication(PublicationType.Article);
			article1.Author = "Richard von der Katz";
			article1.Title = "Keine Angst von Mäusen!";
			article1.Year = "1896";
			folder2.Children.Add(new CollectionNode(article1));

			Publication book3 = new Publication(PublicationType.Book);
			book3.Author = "Jesaya Krumm";
			book3.Title = "I know everything";
			book3.Year = "2021";

			folder3.Children.Add(new CollectionNode(book3));

			XElement x = root.ToXElement();

			CollectionNode root1 = CollectionNode.FromXElement(x);
		}
	}
}
