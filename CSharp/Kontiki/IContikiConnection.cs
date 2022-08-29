/***********************************************************************************
* File:         IContikiConnection.cs                                              *
* Contents:     Interface IContikiConnection                                       *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-29 07:11                                                   *
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
	/// <summary>
	/// Most abstract description of a kontiki connection: not necessarily LibGen.
	/// </summary>
	public interface IContikiConnection
	{
		#region Properties
		/// <summary>
		/// Unique name of a base URL, e.g. "Default" or "Proxy01".
		/// </summary>
		string	Name			{get;set;}

		/// <summary>
		/// Endpoint URL of the base.
		/// </summary>
		string	Url				{get;set;}

		/// <summary>
		/// True, if the endpoint is online and accessible.
		/// </summary>
		bool	IsOnline		{get;set;}

		/// <summary>
		/// Time in ms to download the title page of LibGen.
		/// </summary>
		int		ConnectionTime	{get;set;}
		#endregion

		#region XML
		XElement ToXElement();
		void FromXElement(XElement x);
		#endregion

		#region Management
		void Verify();
		#endregion

		#region Query/Retrieve
		/// <summary>
		/// Carries out a general query for books using defined tokens like title and author(s) name(s).
		/// </summary>
		/// <param name="tokens">String containing the query tokens.</param>
		/// <param name="publicationType">Type of the publication. In this version, either Book or Article.</param>
		/// <param name="queryColumn">The column to query by.</param>
		/// <returns>A list containing the publications found.</returns>
		List<Publication> Query(string tokens, PublicationType publicationType, QueryColumn queryColumn = QueryColumn.Default);

		/// <summary>
		/// Retrieves a publication using the unique system Id of the source (such as MD5 with LibGen).
		/// </summary>
		/// <param name="systemId">The system Id to retrieve.</param>
		/// <returns>An instance of publication, if found, otherwise null.</returns>
		Publication Retrieve(string systemId);

		/// <summary>
		/// Retrieves the BibTeX reference of a publication using the unique system Id of the source (such as MD5 with LibGen).
		/// </summary>
		/// <param name="systemId">The system Id to retrieve.</param>
		/// <returns>The BibTeX reference of the publication, if found, otherwise null.</returns>
		string RetrieveBibTeX(string systemId);
		#endregion
	}
}
