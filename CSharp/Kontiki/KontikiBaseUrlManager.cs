/***********************************************************************************
* File:         KontikiBaseUrlManager.cs                                           *
* Contents:     Class KontikiBaseUrlManager                                        *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-17 22:38                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;

namespace Kontiki
{
	public class KontikiBaseUrlManager: IKontikiBaseUrlManager
	{
		#region Properties
		/// <summary>
		/// Working dictionary of base urls.
		/// Key:	the unique name of the base url;
		/// value:	the instance.
		/// </summary>
		public Dictionary<string, KontikiBaseUrl> BaseUrls {get;internal set;} = new Dictionary<string, KontikiBaseUrl>();
		#endregion

		/// <summary>
		/// Adds a base url to the working dictionary if the name is not already present in the working dictionary.
		/// </summary>
		/// <param name="baseUrl">The base url to add.</param>
		public void AddBaseUrl(KontikiBaseUrl baseUrl)
		{
			if (!this.BaseUrls.ContainsKey(baseUrl.Name))
			{
				this.BaseUrls.Add(baseUrl.Name, baseUrl);
			}
		}

		/// <summary>
		/// Edits an existing base url.
		/// </summary>
		/// <param name="baseUrl"></param>
		public void EditBaseUrl(KontikiBaseUrl baseUrl)
		{
			if (this.BaseUrls.ContainsKey(baseUrl.Name))
			{
				this.BaseUrls[baseUrl.Name] = baseUrl;
			}
		}

		/// <summary>
		/// Tries to delete a base URL by its name.
		/// </summary>
		/// <param name="name"></param>
		public void DeleteBaseUrl(string name)
		{
			if (this.BaseUrls.ContainsKey(name))
			{
				this.BaseUrls.Remove(name);
			}
		}

		/// <summary>
		/// Tests a base url. The connection data are written into the instance fields.
		/// </summary>
		/// <param name="baseUrl"></param>
		public void TestBaseUrl(KontikiBaseUrl baseUrl)
		{
			WebRequest request = HttpWebRequest.Create(baseUrl.EndPoint);

			try
			{
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();

				using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
				{
					stopwatch.Stop();
					baseUrl.IsOnline	= response.StatusCode == HttpStatusCode.OK;
					
					if (baseUrl.IsOnline)
					{
						baseUrl.ConnectionTime = (int)stopwatch.ElapsedMilliseconds;
					}
					else
					{
						baseUrl.ConnectionTime = -1;
					}
				}
			}
			catch (Exception)
			{
				baseUrl.IsOnline		= false;
				baseUrl.ConnectionTime	= -1;
			}
		}

		/// <summary>
		/// Creates an XElement containing the base urls.
		/// </summary>
		/// <returns></returns>
		public XElement ToXElement()
		{
			XElement x = new XElement("BaseUrls");

			foreach (string name in this.BaseUrls.Keys)
			{
				x.Add(this.BaseUrls[name].ToXElement());
			}

			return x;
		}

		/// <summary>
		/// Restores the base urls from an XElement.
		/// </summary>
		/// <param name="x"></param>f
		public void FromXElement(XElement x)
		{
			this.BaseUrls.Clear();

			foreach (XElement xItem in x.Elements("KontikiBaseUrl"))
			{
				KontikiBaseUrl baseUrl = KontikiBaseUrl.FromXElement(xItem);
				this.BaseUrls.Add(baseUrl.Name, baseUrl);
			}
		}

		/// <summary>
		/// Saves the base urls as an XML file.
		/// </summary>
		/// <param name="fileName"></param>
		public void Save(string fileName)
		{
			this.ToXElement().Save(fileName);
		}

		/// <summary>
		/// Restores the base urls from an XML file.
		/// </summary>
		/// <param name="fileName"></param>
		public void Load(string fileName)
		{
			XElement x = XElement.Load(fileName);
			this.FromXElement(x);
		}
	}
}
