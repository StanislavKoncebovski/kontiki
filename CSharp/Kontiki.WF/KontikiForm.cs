/***********************************************************************************
* File:         KontikiForm.cs                                                     *
* Contents:     Class KontikiForm                                                  *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-23 12:24                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System.Windows.Forms;
using Kontiki.Collection;

namespace Kontiki.WF
{
	public partial class KontikiForm : Form
	{
		private static string _connectionFileName		= "kontiki_connections.xml";
		public static HapKontikiManager KontikiManager	= new HapKontikiManager();

		private KontikiCollection	_collection			= null;
		private string				_collectionFileName = null;

		public KontikiForm()
		{
			InitializeComponent();

			this.PrepareKontikiConnection();
		}

		private void PrepareKontikiConnection(string connectionName = "default")
		{
			KontikiManager.ConnectionManager.Load(_connectionFileName);
			KontikiConnection connection = KontikiManager.ConnectionManager.Connections[connectionName];
			KontikiManager.ConnectionManager.TestConnection(connection);

			if (connection.IsOnline)
			{
				MessageBox.Show($"Connection {connectionName} is online");
			}
			else
			{
				MessageBox.Show($"Connection {connectionName} is NOT online");
			}
		}

		private void OnCollectionNew(object sender, System.EventArgs e)
		{
			this._collection	= new KontikiCollection("aaa", "ddd");
		}

		private void OnCollectionLoad(object sender, System.EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Kontiki collection files (*.kontiki)|*.kontiki";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._collectionFileName	= dialog.FileName;
				this._collection			= KontikiCollection.Load(this._collectionFileName);
			}
		}

		private void OnCollectionQuit(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
