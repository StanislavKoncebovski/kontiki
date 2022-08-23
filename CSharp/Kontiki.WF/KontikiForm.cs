/***********************************************************************************
* File:         KontikiForm.cs                                                     *
* Contents:     Class KontikiForm                                                  *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-23 12:24                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System.Linq;
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
				this.DisplayCollectionFolders();
			}
		}

		private void OnCollectionQuit(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void DisplayCollectionFolders()
		{
			this._tvCollection.Nodes.Clear();

			TreeNode tnRoot = this.CreateCollectionTreeNode(_collection.Root);

			this._tvCollection.Nodes.Add(tnRoot);
		}

		private TreeNode CreateCollectionTreeNode(CollectionNode node)
		{
			if (node.IsPublication)
			{
				return null;
			}

			TreeNode tnFolder	= new TreeNode(node.FolderName);
			tnFolder.Tag		= node;

			foreach (CollectionNode child in node.Children)
			{
				TreeNode tnChild = this.CreateCollectionTreeNode(child);

				if (tnChild != null)
				{
					tnFolder.Nodes.Add(tnChild);
				}
			}

			return tnFolder;
		}

		private void OnSelectedNodeChanged(object sender, TreeViewEventArgs e)
		{
			if (this._tvCollection.SelectedNode != null)
			{
				CollectionNode node = this._tvCollection.SelectedNode.Tag as CollectionNode;

				if (node.IsFolder)
				{
					this._lbPublications.Items.Clear();

					foreach (CollectionNode child in node.Children.Where(c => c.IsPublication))
					{
						this._lbPublications.Items.Add(child.Publication);
					}
				}
			}
		}

		private void OnPublicstionSelected(object sender, System.EventArgs e)
		{
			Publication publication = this._lbPublications.SelectedItem as Publication;

			this._txPublicationBibTeX.Text = publication.ToBibTeX();
		}
	}
}
