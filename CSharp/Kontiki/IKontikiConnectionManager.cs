/***********************************************************************************
* File:         IKontikiConnectionManager.cs                                       *
* Contents:     Interface IKontikiConnectionManager                                *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-18 12:05                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System.Collections.Generic;
using System.Xml.Linq;

namespace Kontiki
{
	public interface IKontikiConnectionManager
	{
		#region Properties
		/// <summary>
		/// Working dictionary of base urls.
		/// Key:	the unique name of the base url;
		/// value:	the instance.
		/// </summary>
		Dictionary<string, KontikiConnection> Connections {get;}

		/// <summary>
		/// Gets or sets the working Base URL key.
		/// </summary>
		KontikiConnection WorkingConnection {get;}

		/// <summary>
		/// Gets the current base URL for book search.
		/// </summary>
		string BookSearchUrl {get;}

		/// <summary>
		/// Gets the current base URL for obtaining the BibTeX reference.
		/// </summary>
		string BibtexUrl {get;}

		/// <summary>
		/// Gets the current base URL for article search.
		/// </summary>
		string ArticleSearchUrl {get;}
		#endregion

		void SelectConnection(string name);

		/// <summary>
		/// Adds a connection to the working dictionary if the name is not already present in the working dictionary.
		/// </summary>
		/// <param name="connection">The base url to add.</param>
		void AddConnection(KontikiConnection connection);

		/// <summary>
		/// Edits an existing connection.
		/// </summary>
		/// <param name="connection"></param>
		void EditConnection(KontikiConnection connection);

		/// <summary>
		/// Tries to delete a base URL by its name.
		/// </summary>
		/// <param name="name"></param>
		void DeleteConnection(string name);

		/// <summary>
		/// Tests a connection. The connection data are written into the instance fields.
		/// </summary>
		/// <param name="connection"></param>
		void TestConnection(KontikiConnection connection);

		/// <summary>
		/// Creates an XElement containing the base urls.
		/// </summary>
		/// <returns></returns>
		XElement ToXElement();

		/// <summary>
		/// Restores the base urls from an XElement.
		/// </summary>
		/// <param name="x"></param>
		void FromXElement(XElement x);

		/// <summary>
		/// Saves the base urls as an XML file.
		/// </summary>
		/// <param name="fileName"></param>
		void Save(string fileName);

		/// <summary>
		/// Restores the base urls from an XML file.
		/// </summary>
		/// <param name="fileName"></param>
		void Load(string fileName);
	}
}
