/***********************************************************************************
* File:         KontikiCollection.cs                                               *
* Contents:     Class KontikiCollection                                            *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-22 22:37                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Kontiki.Collection
{
	public class KontikiCollection 
	{
		#region Properties
		/// <summary>
		/// The name of the collection.
		/// </summary>
		public string			Name		{get;set;}	= null;

		/// <summary>
		/// Description (optional).
		/// </summary>
		public string			Description	{get;set;}	= null;

		public CollectionNode	Root		{get;set;}	= null;
		#endregion

		#region Construction
		public KontikiCollection(string name, string description = "")
		{
			this.Name			= name;
			this.Description	= description;

			this.Root			= new CollectionNode("Root");
		}

		public KontikiCollection(): this("") {}
		#endregion

		#region XML
		public XElement ToXElement()
		{
			XElement x = new XElement("KontikiCollection");
			x.Add(new XAttribute("Name", this.Name));
			x.Add(new XElement("Description", this.Description));

			XElement xRoot = this.Root.ToXElement();
			x.Add(xRoot);

			return x;
		}

		public static KontikiCollection FromXElement(XElement x)
		{
			KontikiCollection collection = new KontikiCollection();

			collection.Name			= x.Attribute("Name").Value;
			collection.Description	= x.Element("Description").Value;

			collection.Root			= CollectionNode.FromXElement(x.Element("CollectionFolder"));

			return collection;
		}
		#endregion

		#region I/O
		public void Save(string fileName)
		{
			this.ToXElement().Save(fileName);
		}

		public static KontikiCollection Load(string fileName)
		{
			return KontikiCollection.FromXElement(XElement.Load(fileName));
		}
		#endregion

		#region Statistics
		public Publication[] GetPublications()
		{
			List<Publication> publications = new List<Publication>();

			this.GetPublications(publications, this.Root);

			return publications.ToArray();
		}

		public string[] GetPublicationIds()
		{
			return this.GetPublications().Select(p => p.Id).ToArray();
		}

		private void GetPublications(List<Publication> publications, CollectionNode node)
		{
			publications.AddRange(node.Children.Where(c => c.IsPublication).Select(t => t.Publication));

			foreach (CollectionNode child in node.Children)
			{
				GetPublications(publications, child);
			}
		}

		public CollectionNode FindPublicationNode(string id)
		{
			return CollectionNode.FindPublicationNode(this.Root, id);
		}
		#endregion
	}
}
