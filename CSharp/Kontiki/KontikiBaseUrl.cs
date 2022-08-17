/***********************************************************************************
* File:         KontikiBaseUrl.cs                                                  *
* Contents:     Class KontikiBaseUrl                                               *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-17 22:07                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace Kontiki
{
	/// <summary>
	/// Holds information of Kontiki base urls.
	/// </summary>
	public class KontikiBaseUrl
	{
		#region Properties
		/// <summary>
		/// Unique name of a base URL, e.g. "Default" or "Proxy01".
		/// </summary>
		public string	Name			{get;set;}

		/// <summary>
		/// Endpoint URL of the base.
		/// </summary>
		public string	EndPoint		{get;set;}

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
		public KontikiBaseUrl(string name, string endPoint, bool isOnline, int connectionTime)
		{
			this.Name			= name;
			this.EndPoint		= endPoint;
			this.IsOnline		= isOnline;
			this.ConnectionTime	= connectionTime;
		}

		public KontikiBaseUrl(string name, string endPoint) : this(name, endPoint, false, -1)													{}
		public KontikiBaseUrl()								: this("", "")																		{}
		public KontikiBaseUrl(KontikiBaseUrl baseUrl)		: this(baseUrl.Name, baseUrl.EndPoint, baseUrl.IsOnline, baseUrl.ConnectionTime)	{}
		#endregion

		#region XML
		public XElement ToXElement()
		{
			XElement x = new XElement("KontikiBaseUrl");

			x.Add(new XAttribute("Name",			this.Name));
			x.Add(new XAttribute("EndPoint",		this.EndPoint));
			x.Add(new XAttribute("IsOnline",		this.IsOnline));
			x.Add(new XAttribute("ConnectionTime",	this.ConnectionTime));

			return x;
		}

		public static KontikiBaseUrl FromXElement(XElement x)
		{
			KontikiBaseUrl baseUrl	= new KontikiBaseUrl();

			baseUrl.Name			= x.Attribute("Name").Value;
			baseUrl.EndPoint		= x.Attribute("EndPoint").Value;
			baseUrl.IsOnline		= Boolean.Parse(x.Attribute("IsOnline").Value);
			baseUrl.ConnectionTime	= Int32.Parse(x.Attribute("ConnectionTime").Value);

			return baseUrl;
		}
		#endregion
	}
}
