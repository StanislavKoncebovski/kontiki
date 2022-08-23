/***********************************************************************************
* File:         KontikiCollection.cs                                               *
* Contents:     Class KontikiCollection                                            *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-22 22:37                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	}
}
