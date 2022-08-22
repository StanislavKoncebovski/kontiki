/***********************************************************************************
* File:         CollectionNode.cs                                                  *
* Contents:     Class CollectionNode                                               *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-22 22:19                                                   *
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
	/// <summary>
	/// Either a Publication or a folder
	/// </summary>
	public class CollectionNode
	{
		#region Properties
		/// <summary>
		/// Valid for Publication nodes
		/// </summary>
		public Publication	Publication			{get;set;}	= null;

		/// <summary>
		/// Valid for Folder nodes
		/// </summary>
		public string		FolderName			{get;set;}	= null;

		/// <summary>
		/// Valid for Publication nodes (optional).
		/// </summary>
		public string		FolderDescription	{get;set;}	= null;

		public CollectionNode Parent			{get;set;}

		public List<CollectionNode> Children {get;internal set;} = new List<CollectionNode>();
		public bool IsPublication
		{
			get {return this.Publication != null;}
		}

		public bool IsFolder
		{
			get {return this.Publication == null && !String.IsNullOrEmpty(this.FolderName);}
		}
		#endregion

		#region Construction
		public CollectionNode(Publication publication)
		{
			this.Publication = publication;
		}

		public CollectionNode(string folderName, string folderDescription)
		{
			this.FolderName			= folderName;
			this.FolderDescription	= folderDescription;
		}
		public CollectionNode(string folderName) : this(folderName, null) {}
		public CollectionNode() {}
		#endregion

		#region XML
		/// <summary>
		/// TODO: needs unit testing
		/// </summary>
		/// <returns></returns>
		public XElement ToXElement()
		{
			if (this.IsPublication)
			{
				return this.Publication.ToXElement();
			}
			else
			{
				XElement x			= new XElement("CollectionFolder");
				x.Add(new XAttribute("FolderName", this.FolderName));
				x.Add(new XElement("FolderDescription", this.FolderDescription));

				XElement xChildren	= new XElement("Children");
				x.Add(xChildren);

				foreach (CollectionNode child in this.Children)
				{
					xChildren.Add(child.ToXElement());
				}
				
				return x;
			}
		}

		/// <summary>
		/// TODO: needs unit testing
		/// </summary>
		/// <returns></returns>
		public static CollectionNode FromXElement(XElement x)
		{
			CollectionNode node			= new CollectionNode();

			if (x.Name == "Publication")
			{
				node.Publication		= Publication.FromXElement(x);
			}
			else if (x.Name == "CollectionFolder")
			{
				node.FolderName			= x.Attribute("FolderName").Value;
				node.FolderDescription	= x.Element("FolderDescription").Value;

				XElement xChildren	= x.Element("Children");

				foreach (XElement xChild in xChildren.Elements())
				{
					node.Children.Add(CollectionNode.FromXElement(xChild));
				}
			}

			return node;
		}
		#endregion
	}
}
