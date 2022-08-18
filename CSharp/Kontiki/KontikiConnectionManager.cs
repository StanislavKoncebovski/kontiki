/***********************************************************************************
* File:         KontikiConnectionManager.cs                                        *
* Contents:     Class KontikiConnectionManager                                     *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-18 12:06                                                   *
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
	public class KontikiConnectionManager: IKontikiConnectionManager
	{
		#region Properties
		/// <summary>
		/// Working dictionary of connections.
		/// Key:	the unique name of the base url;
		/// value:	the instance.
		/// </summary>
		public Dictionary<string, KontikiConnection> Connections {get;internal set;} = new Dictionary<string, KontikiConnection>();

		/// <summary>
		/// Gets or sets the working Base URL key.
		/// </summary>
		public KontikiConnection WorkingConnection {get;internal set;}

		/// <summary>
		/// Gets the current base URL for book search.
		/// </summary>
		public string BookSearchUrl 
		{
			get
			{
				if (this.WorkingConnection != null)
				{
					return $"{this.WorkingConnection.Url}/search.php";
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Gets the current base URL for obtaining the BibTeX reference.
		/// </summary>
		public string BibtexUrl
		{
			get
			{
				if (this.WorkingConnection != null)
				{
					return $"{this.WorkingConnection.Url}/book/bibtex.php";
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Gets the current base URL for article search.
		/// </summary>
		public string ArticleSearchUrl
		{
			get
			{
				if (this.WorkingConnection != null)
				{
					return $"{this.WorkingConnection.Url}/scimag";
				}
				else
				{
					return null;
				}
			}
		}
		#endregion

		public void SelectConnection(string name)
		{
			if (this.Connections.ContainsKey(name))
			{
				this.WorkingConnection = this.Connections[name];
			}
		}

		/// <summary>
		/// Adds a connection to the working dictionary if the name is not already present in the working dictionary.
		/// </summary>
		/// <param name="connection">The base url to add.</param>
		public void AddConnection(KontikiConnection connection)
		{
			if (!this.Connections.ContainsKey(connection.Name))
			{
				this.Connections.Add(connection.Name, connection);
			}
		}

		/// <summary>
		/// Edits an existing connection.
		/// </summary>
		/// <param name="connection"></param>
		public void EditConnection(KontikiConnection connection)
		{
			if (this.Connections.ContainsKey(connection.Name))
			{
				this.Connections[connection.Name] = connection;
			}
		}

		/// <summary>
		/// Tries to delete a connection by its name.
		/// </summary>
		/// <param name="name"></param>
		public void DeleteConnection(string name)
		{
			if (this.Connections.ContainsKey(name))
			{
				this.Connections.Remove(name);
			}
		}

		/// <summary>
		/// Tests a base url. The connection data are written into the instance fields.
		/// </summary>
		/// <param name="connection"></param>
		public void TestConnection(KontikiConnection connection)
		{
			WebRequest request = HttpWebRequest.Create(connection.Url);

			try
			{
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();

				using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
				{
					stopwatch.Stop();
					connection.IsOnline	= response.StatusCode == HttpStatusCode.OK;
					
					if (connection.IsOnline)
					{
						connection.ConnectionTime = (int)stopwatch.ElapsedMilliseconds;
						this.WorkingConnection = connection;
					}
					else
					{
						connection.ConnectionTime = -1;
					}
				}
			}
			catch (Exception)
			{
				connection.IsOnline		= false;
				connection.ConnectionTime	= -1;
			}
		}

		/// <summary>
		/// Creates an XElement containing the base urls.
		/// </summary>
		/// <returns></returns>
		public XElement ToXElement()
		{
			XElement x = new XElement("KontikiConnections");

			foreach (string name in this.Connections.Keys)
			{
				x.Add(this.Connections[name].ToXElement());
			}

			return x;
		}

		/// <summary>
		/// Restores the base urls from an XElement.
		/// </summary>
		/// <param name="x"></param>f
		public void FromXElement(XElement x)
		{
			this.Connections.Clear();

			foreach (XElement xItem in x.Elements("KontikiConnection"))
			{
				KontikiConnection connection = KontikiConnection.FromXElement(xItem);
				this.Connections.Add(connection.Name, connection);
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
