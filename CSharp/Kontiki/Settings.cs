/***********************************************************************************
* File:         Settings.cs                                                        *
* Contents:     Class Settings                                                     *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-26 13:03                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kontiki
{
	public class Settings
	{
		#region Private Members
		private static string				_companyName			= "pikkatech.eu";
		private static string				_applicationName		= "Kontiki";
		private static string				_settingsFileName		= "kontikiSettings.xml";
		#endregion

		#region XML
		public XElement ToXElement()
		{
			throw new NotImplementedException();
		}

		public static Settings FromXElement(XElement x)
		{
			throw new NotImplementedException();
		}
		#endregion

		#region I/O
		public void Save()
		{
			string appFolderName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _companyName, _applicationName);

			if (!Directory.Exists(appFolderName))
			{
				Directory.CreateDirectory(appFolderName);
			}

			string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _companyName, _applicationName, _settingsFileName);

			this.ToXElement().Save(fileName);
		}

		public static Settings Load()
		{
			string appFolderName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _companyName, _applicationName);
			if (!Directory.Exists(appFolderName))
			{
				Directory.CreateDirectory(appFolderName);
			}

			try
			{
				string fileName			= Path.Combine(appFolderName, _settingsFileName);

				return FromXElement(XElement.Load(fileName));
			}
			catch (Exception)
			{
				MessageBox.Show("No settins file found. Saving Default values instead.", "Configuration error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
		#endregion
	}
}
