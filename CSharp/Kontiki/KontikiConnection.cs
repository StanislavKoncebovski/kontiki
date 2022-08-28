/***********************************************************************************
* File:         KontikiConnection.cs                                               *
* Contents:     Class KontikiConnection                                            *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-18 12:00                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Xml.Linq;

namespace Kontiki
{
	/// <summary>
	/// Holds information of Kontiki connections (base urls).
	/// </summary>
	public class KontikiConnection
	{
		#region Properties
		/// <summary>
		/// Unique name of a base URL, e.g. "Default" or "Proxy01".
		/// </summary>
		public string	Name			{get;set;}

		/// <summary>
		/// Endpoint URL of the base.
		/// </summary>
		public string	Url				{get;set;}

		/// <summary>
		/// True, if the endpoint is online and accessible.
		/// </summary>
		public bool		IsOnline		{get;set;}

		/// <summary>
		/// Time in ms to download the title page of LibGen.
		/// </summary>
		public int		ConnectionTime	{get;set;}
		#endregion

		#region Construction
		public KontikiConnection(string name, string url, bool isOnline, int connectionTime)
		{
			this.Name			= name;
			this.Url			= url;
			this.IsOnline		= isOnline;
			this.ConnectionTime	= connectionTime;
		}

		public KontikiConnection(string name, string url)		: this(name, url, false, -1)															{}
		public KontikiConnection()								: this("", "")																			{}
		public KontikiConnection(KontikiConnection connection)	: this(connection.Name, connection.Url, connection.IsOnline, connection.ConnectionTime)	{}
		#endregion

		#region XML
		public XElement ToXElement()
		{
			XElement x = new XElement("KontikiConnection");

			x.Add(new XAttribute("Name",			this.Name));
			x.Add(new XAttribute("Url",				this.Url));
			x.Add(new XAttribute("IsOnline",		this.IsOnline));
			x.Add(new XAttribute("ConnectionTime",	this.ConnectionTime));

			return x;
		}

		public static KontikiConnection FromXElement(XElement x)
		{
			KontikiConnection connection	= new KontikiConnection();

			connection.Name					= x.Attribute("Name").Value;
			connection.Url					= x.Attribute("Url").Value;
			connection.IsOnline				= Boolean.Parse(x.Attribute("IsOnline").Value);
			connection.ConnectionTime		= Int32.Parse(x.Attribute("ConnectionTime").Value);

			return connection;
		}
		#endregion
	}
}
