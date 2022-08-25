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
using Kontiki.WF.Gui.Dialogs;

namespace Kontiki.WF
{
	public partial class KontikiForm : Form
	{
		#region Private Members
		private static string _connectionFileName		= "kontiki_connections.xml";
		private KontikiCollection	_collection			= null;
		private string				_collectionFileName = null;
		#endregion

		#region Inernal members
		internal static HapKontikiManager KontikiManager	= new HapKontikiManager();
		#endregion

		#region Construction
		public KontikiForm()
		{
			InitializeComponent();

			this._ctrlQuery.PublicationsSelected += this.OnQueryPublicationsSelected;

			this.PrepareKontikiConnection();
		}
		#endregion

		#region Menu event handlers
		private void OnCollectionNew(object sender, System.EventArgs e)
		{
			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text = "Collection Properties";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._collection = new KontikiCollection(dialog.ItemName, dialog.ItemDescription);
				PublicationIdCreator.Collection = this._collection;
			}
		}

		private void OnCollectionEdit(object sender, System.EventArgs e)
		{
			if (this._collection == null)
			{
				return;
			}

			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text = "Collection Properties";

			dialog.ItemName	= this._collection.Name;
			dialog.ItemDescription	= this._collection.Description;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._collection.Name			= dialog.ItemName;
				this._collection.Description	= dialog.ItemDescription;
				PublicationIdCreator.Collection = this._collection;
			}
		}

		private void OnCollectionClose(object sender, System.EventArgs e)
		{
			if (this._collection == null)
			{
				return;
			}

			// TODO ask for saving
			this._collection = null;
			PublicationIdCreator.Collection = this._collection;
		}

		private void OnCollectionLoad(object sender, System.EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Kontiki collection files (*.kontiki)|*.kontiki";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._collectionFileName	= dialog.FileName;
				this._collection			= KontikiCollection.Load(this._collectionFileName);
				PublicationIdCreator.Collection = this._collection;
				this.DisplayCollectionFolders();
			}
		}

		private void OnCollectionQuit(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void OnCollectionSave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(this._collectionFileName))
			{
				this.OnCollectionSaveAs(sender, e);
			}
			else
			{
				this._collection.Save(this._collectionFileName);
			}
		}

		private void OnCollectionSaveAs(object sender, System.EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();

			dialog.Filter = "Kontiki collection files (*.kontiki)|*.kontiki";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._collectionFileName = dialog.FileName;

				this.OnCollectionSave(sender, e);
			}
		}
		#endregion

		#region GUI event handlers
		private void OnSelectedNodeChanged(object sender, TreeViewEventArgs e)
		{
			if (this._tvCollection.SelectedNode != null)
			{
				CollectionNode node = this._tvCollection.SelectedNode.Tag as CollectionNode;

				if (node.IsFolder)
				{
					this.DisplayNodePublications(node);
				}
			}
		}

		private void DisplayNodePublications(CollectionNode node)
		{
			this._lbPublications.Items.Clear();

			foreach (CollectionNode child in node.Children.Where(c => c.IsPublication))
			{
				this._lbPublications.Items.Add(child.Publication);
			}
		}

		private void OnPublicationSelected(object sender, System.EventArgs e)
		{
			Publication publication = this._lbPublications.SelectedItem as Publication;

			if (publication != null)
			{
				this._txPublicationBibTeX.Text = publication.ToBibTeX();
			}
		}

		private void OnQueryPublicationsSelected(Publication[] publications)
		{
			if (this._tvCollection.SelectedNode == null)
			{
				return;
			}

			CollectionNode nodeSelected = this._tvCollection.SelectedNode.Tag as CollectionNode;

			if (nodeSelected.IsFolder)
			{
				foreach (Publication publication in publications)
				{
					publication.Id	= PublicationIdCreator.CreateId(publication);
					nodeSelected.AddChild(new CollectionNode(publication));
				}

				this.OnSelectedNodeChanged(null, null);
			}
		}
		#endregion

		#region Private auxiliary
		private void DisplayCollectionFolders()
		{
			this._tvCollection.Nodes.Clear();

			TreeNode tnRoot = this.CreateCollectionTreeNode(_collection.Root);

			this._tvCollection.Nodes.Add(tnRoot);

			this._tvCollection.ExpandAll();
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

		private void PrepareKontikiConnection(string connectionName = "default")
		{
			try
			{
				KontikiManager.ConnectionManager.Load(_connectionFileName);
			}
			catch (System.Exception)
			{
				MessageBox.Show($"Configuration file {_connectionFileName} not found");
				return;
			}
			
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
		#endregion

		private void OnFolderNew(object sender, System.EventArgs e)
		{
			if (this._collection == null)
			{
				return;
			}

			if (this._tvCollection.SelectedNode == null)
			{
				return;
			}

			CollectionNode node = this._tvCollection.SelectedNode.Tag as CollectionNode;

			if (!node.IsFolder)
			{
				return;
			}

			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text = "Folder Properties";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				CollectionNode child = new CollectionNode(dialog.ItemName, dialog.ItemDescription);
				node.AddChild(child);

				this.DisplayCollectionFolders();
			}
		}

		private void OnFolderEdit(object sender, System.EventArgs e)
		{
			if (this._collection == null)
			{
				return;
			}

			if (this._tvCollection.SelectedNode == null)
			{
				return;
			}

			CollectionNode node = this._tvCollection.SelectedNode.Tag as CollectionNode;

			if (!node.IsFolder)
			{
				return;
			}

			ItemPropertiesDialog dialog = new ItemPropertiesDialog();
			dialog.Text				= "Folder Properties";
			dialog.ItemName			= node.FolderName;
			dialog.ItemDescription	= node.FolderDescription;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				node.FolderName			= dialog.ItemName;
				node.FolderDescription	= dialog.ItemDescription;

				this.DisplayCollectionFolders();
			}
		}

		private void OnFolderDelete(object sender, System.EventArgs e)
		{
			if (this._collection == null)
			{
				return;
			}

			if (this._tvCollection.SelectedNode == null)
			{
				return;
			}

			CollectionNode node = this._tvCollection.SelectedNode.Tag as CollectionNode;

			if (!node.IsFolder)
			{
				return;
			}

			if (
					MessageBox.Show($"Delete folder {node.FolderName} with all its contents?", 
					"Folder to be deleted", 
					MessageBoxButtons.OKCancel, 
					MessageBoxIcon.Question
				) == DialogResult.OK)
			{
				if (node.Parent != null)
				{
					node.Parent.RemoveChild(node);
					this.DisplayCollectionFolders();
					this._lbPublications.Items.Clear();
				}
			}
		}

		private void OnPublicationAdd(object sender, System.EventArgs e)
		{
			PublicationDialog dialog	= new PublicationDialog();
			dialog.Publication			= new Publication();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				Publication publication	= dialog.Publication;

				CollectionNode nodeSelected = this._tvCollection.SelectedNode.Tag as CollectionNode;

				if (nodeSelected.IsFolder)
				{
					publication.Id	= PublicationIdCreator.CreateId(publication);
					nodeSelected.AddChild(new CollectionNode(publication));

					this.OnSelectedNodeChanged(null, null);
				}
			}
		}

		private void OnPublicationEdit(object sender, System.EventArgs e)
		{
			if (this._lbPublications.SelectedItem != null)
			{
				Publication publication = this._lbPublications.SelectedItem as Publication;
			}
		}

		private void OnPublicationDelete(object sender, System.EventArgs e)
		{
			if (this._collection == null)
			{
				return;
			}

			if (this._lbPublications.SelectedItem != null)
			{
				Publication publication = this._lbPublications.SelectedItem as Publication;

				if (
					MessageBox.Show($"Delete publication {publication} ?", 
					"Publication to be deleted", 
					MessageBoxButtons.OKCancel, 
					MessageBoxIcon.Question
				) == DialogResult.OK)
				{
					CollectionNode node = this._collection.FindPublicationNode(publication.Id);

					CollectionNode parent = node.Parent;

					node.Parent.RemoveChild(node);

					this.DisplayNodePublications(parent);

					this._txPublicationBibTeX.Clear();
				}
			}
		}
	}
}
