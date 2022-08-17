/***********************************************************************************
* File:         IKontikiBaseUrlManager.cs                                          *
* Contents:     Interface IKontikiBaseUrlManager                                   *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-17 22:18                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kontiki
{
	public interface IKontikiBaseUrlManager
	{
		#region Properties
		/// <summary>
		/// Working dictionary of base urls.
		/// Key:	the unique name of the base url;
		/// value:	the instance.
		/// </summary>
		Dictionary<string, KontikiBaseUrl> BaseUrls {get;}
		#endregion

		/// <summary>
		/// Adds a base url to the working dictionary if the name is not already present in the working dictionary.
		/// </summary>
		/// <param name="baseUrl">The base url to add.</param>
		void AddBaseUrl(KontikiBaseUrl baseUrl);

		/// <summary>
		/// Edits an existing base url.
		/// </summary>
		/// <param name="baseUrl"></param>
		void EditBaseUrl(KontikiBaseUrl baseUrl);

		/// <summary>
		/// Tries to delete a base URL by its name.
		/// </summary>
		/// <param name="name"></param>
		void DeleteBaseUrl(string name);

		/// <summary>
		/// Tests a base url. The connection data are written into the instance fields.
		/// </summary>
		/// <param name="baseUrl"></param>
		void TestBaseUrl(KontikiBaseUrl baseUrl);

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
