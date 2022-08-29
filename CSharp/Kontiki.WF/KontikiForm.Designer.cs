
namespace Kontiki.WF
{
	partial class KontikiForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontikiForm));
			this._msKontiki = new System.Windows.Forms.MenuStrip();
			this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._stsKontiki = new System.Windows.Forms.StatusStrip();
			this._tsKontiki = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this._scCollection = new System.Windows.Forms.SplitContainer();
			this._tvCollection = new System.Windows.Forms.TreeView();
			this._cmsCollection = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._ilFolders = new System.Windows.Forms.ImageList(this.components);
			this._scQuery = new System.Windows.Forms.SplitContainer();
			this._scPublications = new System.Windows.Forms.SplitContainer();
			this._lvPublications = new System.Windows.Forms.ListView();
			this.PublicationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._tcPublication = new System.Windows.Forms.TabControl();
			this._tpPublicationBibTeX = new System.Windows.Forms.TabPage();
			this._txPublicationBibTeX = new System.Windows.Forms.TextBox();
			this._tpPublicationInstance = new System.Windows.Forms.TabPage();
			this._ctrlPublication = new Kontiki.WF.Gui.Controls.PublicationControl();
			this._ctrlQuery = new Kontiki.WF.Gui.Controls.QueryControl();
			this._cmsPublication = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addPublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editPublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deletePublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exportToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bibTeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._msKontiki.SuspendLayout();
			this._tsKontiki.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._scCollection)).BeginInit();
			this._scCollection.Panel1.SuspendLayout();
			this._scCollection.Panel2.SuspendLayout();
			this._scCollection.SuspendLayout();
			this._cmsCollection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._scQuery)).BeginInit();
			this._scQuery.Panel1.SuspendLayout();
			this._scQuery.Panel2.SuspendLayout();
			this._scQuery.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._scPublications)).BeginInit();
			this._scPublications.Panel1.SuspendLayout();
			this._scPublications.Panel2.SuspendLayout();
			this._scPublications.SuspendLayout();
			this._tcPublication.SuspendLayout();
			this._tpPublicationBibTeX.SuspendLayout();
			this._tpPublicationInstance.SuspendLayout();
			this._cmsPublication.SuspendLayout();
			this.SuspendLayout();
			// 
			// _msKontiki
			// 
			this._msKontiki.Font = new System.Drawing.Font("Consolas", 10F);
			this._msKontiki.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this._msKontiki.Location = new System.Drawing.Point(0, 0);
			this._msKontiki.Name = "_msKontiki";
			this._msKontiki.Size = new System.Drawing.Size(1237, 25);
			this._msKontiki.TabIndex = 0;
			this._msKontiki.Text = "menuStrip1";
			// 
			// collectionToolStripMenuItem
			// 
			this.collectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
			this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
			this.collectionToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
			this.collectionToolStripMenuItem.Text = "&Collection";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionNew);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionEdit);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionClose);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.loadToolStripMenuItem.Text = "&Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionLoad);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionSave);
			// 
			// saveasToolStripMenuItem
			// 
			this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
			this.saveasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveasToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.saveasToolStripMenuItem.Text = "Save &as";
			this.saveasToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionSaveAs);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.quitToolStripMenuItem.Text = "&Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionQuit);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.settingsToolStripMenuItem.Text = "&Settings";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			// 
			// _stsKontiki
			// 
			this._stsKontiki.Location = new System.Drawing.Point(0, 615);
			this._stsKontiki.Name = "_stsKontiki";
			this._stsKontiki.Size = new System.Drawing.Size(1237, 22);
			this._stsKontiki.TabIndex = 1;
			this._stsKontiki.Text = "statusStrip1";
			// 
			// _tsKontiki
			// 
			this._tsKontiki.AutoSize = false;
			this._tsKontiki.ImageScalingSize = new System.Drawing.Size(38, 38);
			this._tsKontiki.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripButton5});
			this._tsKontiki.Location = new System.Drawing.Point(0, 25);
			this._tsKontiki.Name = "_tsKontiki";
			this._tsKontiki.Size = new System.Drawing.Size(1237, 40);
			this._tsKontiki.TabIndex = 2;
			this._tsKontiki.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::Kontiki.WF.Properties.Resources.CollectionNew;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(42, 37);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Create new collection";
			this.toolStripButton1.Click += new System.EventHandler(this.OnCollectionNew);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::Kontiki.WF.Properties.Resources.CollectionLoad;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(42, 37);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.Click += new System.EventHandler(this.OnCollectionLoad);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = global::Kontiki.WF.Properties.Resources.CollectionSave;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(42, 37);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.Click += new System.EventHandler(this.OnCollectionSave);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.AutoSize = false;
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = global::Kontiki.WF.Properties.Resources.Settings;
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Margin = new System.Windows.Forms.Padding(0);
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(40, 40);
			this.toolStripButton4.Text = "toolStripButton4";
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = global::Kontiki.WF.Properties.Resources.Quit;
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(42, 37);
			this.toolStripButton5.Text = "toolStripButton5";
			this.toolStripButton5.Click += new System.EventHandler(this.OnCollectionQuit);
			// 
			// _scCollection
			// 
			this._scCollection.Dock = System.Windows.Forms.DockStyle.Fill;
			this._scCollection.Location = new System.Drawing.Point(0, 65);
			this._scCollection.Margin = new System.Windows.Forms.Padding(0);
			this._scCollection.Name = "_scCollection";
			// 
			// _scCollection.Panel1
			// 
			this._scCollection.Panel1.Controls.Add(this._tvCollection);
			// 
			// _scCollection.Panel2
			// 
			this._scCollection.Panel2.Controls.Add(this._scQuery);
			this._scCollection.Size = new System.Drawing.Size(1237, 550);
			this._scCollection.SplitterDistance = 236;
			this._scCollection.TabIndex = 4;
			// 
			// _tvCollection
			// 
			this._tvCollection.ContextMenuStrip = this._cmsCollection;
			this._tvCollection.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tvCollection.ImageIndex = 0;
			this._tvCollection.ImageList = this._ilFolders;
			this._tvCollection.Location = new System.Drawing.Point(0, 0);
			this._tvCollection.Margin = new System.Windows.Forms.Padding(0);
			this._tvCollection.Name = "_tvCollection";
			this._tvCollection.SelectedImageIndex = 0;
			this._tvCollection.Size = new System.Drawing.Size(236, 550);
			this._tvCollection.TabIndex = 0;
			this._tvCollection.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnSelectedNodeChanged);
			// 
			// _cmsCollection
			// 
			this._cmsCollection.Font = new System.Drawing.Font("Consolas", 10F);
			this._cmsCollection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.editFolderToolStripMenuItem,
            this.deleteFolderToolStripMenuItem});
			this._cmsCollection.Name = "_cmsCollection";
			this._cmsCollection.Size = new System.Drawing.Size(181, 70);
			// 
			// newFolderToolStripMenuItem
			// 
			this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
			this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newFolderToolStripMenuItem.Text = "&New Folder";
			this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.OnFolderNew);
			// 
			// editFolderToolStripMenuItem
			// 
			this.editFolderToolStripMenuItem.Name = "editFolderToolStripMenuItem";
			this.editFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editFolderToolStripMenuItem.Text = "&Edit Folder";
			this.editFolderToolStripMenuItem.Click += new System.EventHandler(this.OnFolderEdit);
			// 
			// deleteFolderToolStripMenuItem
			// 
			this.deleteFolderToolStripMenuItem.Name = "deleteFolderToolStripMenuItem";
			this.deleteFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.deleteFolderToolStripMenuItem.Text = "&Delete Folder";
			this.deleteFolderToolStripMenuItem.Click += new System.EventHandler(this.OnFolderDelete);
			// 
			// _ilFolders
			// 
			this._ilFolders.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilFolders.ImageStream")));
			this._ilFolders.TransparentColor = System.Drawing.Color.Transparent;
			this._ilFolders.Images.SetKeyName(0, "Article");
			this._ilFolders.Images.SetKeyName(1, "Book");
			this._ilFolders.Images.SetKeyName(2, "Folder");
			// 
			// _scQuery
			// 
			this._scQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this._scQuery.Location = new System.Drawing.Point(0, 0);
			this._scQuery.Name = "_scQuery";
			// 
			// _scQuery.Panel1
			// 
			this._scQuery.Panel1.Controls.Add(this._scPublications);
			// 
			// _scQuery.Panel2
			// 
			this._scQuery.Panel2.Controls.Add(this._ctrlQuery);
			this._scQuery.Size = new System.Drawing.Size(997, 550);
			this._scQuery.SplitterDistance = 530;
			this._scQuery.TabIndex = 0;
			// 
			// _scPublications
			// 
			this._scPublications.Dock = System.Windows.Forms.DockStyle.Fill;
			this._scPublications.Location = new System.Drawing.Point(0, 0);
			this._scPublications.Margin = new System.Windows.Forms.Padding(0);
			this._scPublications.Name = "_scPublications";
			this._scPublications.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _scPublications.Panel1
			// 
			this._scPublications.Panel1.Controls.Add(this._lvPublications);
			// 
			// _scPublications.Panel2
			// 
			this._scPublications.Panel2.Controls.Add(this._tcPublication);
			this._scPublications.Size = new System.Drawing.Size(530, 550);
			this._scPublications.SplitterDistance = 288;
			this._scPublications.TabIndex = 0;
			// 
			// _lvPublications
			// 
			this._lvPublications.AllowDrop = true;
			this._lvPublications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PublicationId,
            this.Author,
            this.Title,
            this.Year});
			this._lvPublications.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lvPublications.FullRowSelect = true;
			this._lvPublications.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this._lvPublications.HideSelection = false;
			this._lvPublications.LargeImageList = this._ilFolders;
			this._lvPublications.Location = new System.Drawing.Point(0, 0);
			this._lvPublications.Margin = new System.Windows.Forms.Padding(0);
			this._lvPublications.Name = "_lvPublications";
			this._lvPublications.ShowItemToolTips = true;
			this._lvPublications.Size = new System.Drawing.Size(530, 288);
			this._lvPublications.SmallImageList = this._ilFolders;
			this._lvPublications.TabIndex = 0;
			this._lvPublications.UseCompatibleStateImageBehavior = false;
			this._lvPublications.View = System.Windows.Forms.View.Details;
			this._lvPublications.SelectedIndexChanged += new System.EventHandler(this.OnPublicationSelected);
			this._lvPublications.DragOver += new System.Windows.Forms.DragEventHandler(this.OnPublicationsDragOver);
			this._lvPublications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPublicationsMouseDown);
			// 
			// PublicationId
			// 
			this.PublicationId.Text = "Id";
			// 
			// Author
			// 
			this.Author.Text = "Author(s)";
			this.Author.Width = 85;
			// 
			// Title
			// 
			this.Title.Text = "Title";
			this.Title.Width = 94;
			// 
			// Year
			// 
			this.Year.Text = "Year";
			// 
			// _tcPublication
			// 
			this._tcPublication.Controls.Add(this._tpPublicationBibTeX);
			this._tcPublication.Controls.Add(this._tpPublicationInstance);
			this._tcPublication.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tcPublication.Location = new System.Drawing.Point(0, 0);
			this._tcPublication.Margin = new System.Windows.Forms.Padding(0);
			this._tcPublication.Name = "_tcPublication";
			this._tcPublication.SelectedIndex = 0;
			this._tcPublication.Size = new System.Drawing.Size(530, 258);
			this._tcPublication.TabIndex = 0;
			// 
			// _tpPublicationBibTeX
			// 
			this._tpPublicationBibTeX.Controls.Add(this._txPublicationBibTeX);
			this._tpPublicationBibTeX.Location = new System.Drawing.Point(4, 24);
			this._tpPublicationBibTeX.Margin = new System.Windows.Forms.Padding(0);
			this._tpPublicationBibTeX.Name = "_tpPublicationBibTeX";
			this._tpPublicationBibTeX.Padding = new System.Windows.Forms.Padding(3);
			this._tpPublicationBibTeX.Size = new System.Drawing.Size(522, 230);
			this._tpPublicationBibTeX.TabIndex = 0;
			this._tpPublicationBibTeX.Text = "BibTeX";
			this._tpPublicationBibTeX.UseVisualStyleBackColor = true;
			// 
			// _txPublicationBibTeX
			// 
			this._txPublicationBibTeX.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txPublicationBibTeX.Location = new System.Drawing.Point(3, 3);
			this._txPublicationBibTeX.Margin = new System.Windows.Forms.Padding(0);
			this._txPublicationBibTeX.Multiline = true;
			this._txPublicationBibTeX.Name = "_txPublicationBibTeX";
			this._txPublicationBibTeX.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txPublicationBibTeX.Size = new System.Drawing.Size(516, 224);
			this._txPublicationBibTeX.TabIndex = 0;
			// 
			// _tpPublicationInstance
			// 
			this._tpPublicationInstance.Controls.Add(this._ctrlPublication);
			this._tpPublicationInstance.Location = new System.Drawing.Point(4, 22);
			this._tpPublicationInstance.Name = "_tpPublicationInstance";
			this._tpPublicationInstance.Padding = new System.Windows.Forms.Padding(3);
			this._tpPublicationInstance.Size = new System.Drawing.Size(522, 232);
			this._tpPublicationInstance.TabIndex = 1;
			this._tpPublicationInstance.Text = "All";
			this._tpPublicationInstance.UseVisualStyleBackColor = true;
			// 
			// _ctrlPublication
			// 
			this._ctrlPublication.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ctrlPublication.Font = new System.Drawing.Font("Consolas", 10F);
			this._ctrlPublication.Location = new System.Drawing.Point(3, 3);
			this._ctrlPublication.Margin = new System.Windows.Forms.Padding(0);
			this._ctrlPublication.Name = "_ctrlPublication";
			this._ctrlPublication.Publication = null;
			this._ctrlPublication.Size = new System.Drawing.Size(516, 226);
			this._ctrlPublication.TabIndex = 0;
			// 
			// _ctrlQuery
			// 
			this._ctrlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ctrlQuery.Font = new System.Drawing.Font("Consolas", 10F);
			this._ctrlQuery.Location = new System.Drawing.Point(0, 0);
			this._ctrlQuery.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this._ctrlQuery.Name = "_ctrlQuery";
			this._ctrlQuery.Size = new System.Drawing.Size(463, 550);
			this._ctrlQuery.TabIndex = 0;
			// 
			// _cmsPublication
			// 
			this._cmsPublication.Font = new System.Drawing.Font("Consolas", 10F);
			this._cmsPublication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPublicationToolStripMenuItem,
            this.editPublicationToolStripMenuItem,
            this.deletePublicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToClipboardToolStripMenuItem});
			this._cmsPublication.Name = "_cmsPublication";
			this._cmsPublication.Size = new System.Drawing.Size(229, 98);
			// 
			// addPublicationToolStripMenuItem
			// 
			this.addPublicationToolStripMenuItem.Name = "addPublicationToolStripMenuItem";
			this.addPublicationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
			this.addPublicationToolStripMenuItem.Text = "&Add Publication";
			this.addPublicationToolStripMenuItem.Click += new System.EventHandler(this.OnPublicationAdd);
			// 
			// editPublicationToolStripMenuItem
			// 
			this.editPublicationToolStripMenuItem.Name = "editPublicationToolStripMenuItem";
			this.editPublicationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
			this.editPublicationToolStripMenuItem.Text = "&Edit Publication";
			this.editPublicationToolStripMenuItem.Click += new System.EventHandler(this.OnPublicationEdit);
			// 
			// deletePublicationToolStripMenuItem
			// 
			this.deletePublicationToolStripMenuItem.Name = "deletePublicationToolStripMenuItem";
			this.deletePublicationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
			this.deletePublicationToolStripMenuItem.Text = "&Delete Publication";
			this.deletePublicationToolStripMenuItem.Click += new System.EventHandler(this.OnPublicationDelete);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(225, 6);
			// 
			// exportToClipboardToolStripMenuItem
			// 
			this.exportToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bibTeXToolStripMenuItem});
			this.exportToClipboardToolStripMenuItem.Name = "exportToClipboardToolStripMenuItem";
			this.exportToClipboardToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
			this.exportToClipboardToolStripMenuItem.Text = "Export to &Clipboard";
			// 
			// bibTeXToolStripMenuItem
			// 
			this.bibTeXToolStripMenuItem.Name = "bibTeXToolStripMenuItem";
			this.bibTeXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
			this.bibTeXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bibTeXToolStripMenuItem.Text = "BibTeX";
			this.bibTeXToolStripMenuItem.Click += new System.EventHandler(this.OnExportToClipboardAsBibTeX);
			// 
			// KontikiForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 637);
			this.Controls.Add(this._scCollection);
			this.Controls.Add(this._tsKontiki);
			this.Controls.Add(this._stsKontiki);
			this.Controls.Add(this._msKontiki);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.MainMenuStrip = this._msKontiki;
			this.Name = "KontikiForm";
			this.Text = "Kontiki 1.0";
			this._msKontiki.ResumeLayout(false);
			this._msKontiki.PerformLayout();
			this._tsKontiki.ResumeLayout(false);
			this._tsKontiki.PerformLayout();
			this._scCollection.Panel1.ResumeLayout(false);
			this._scCollection.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._scCollection)).EndInit();
			this._scCollection.ResumeLayout(false);
			this._cmsCollection.ResumeLayout(false);
			this._scQuery.Panel1.ResumeLayout(false);
			this._scQuery.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._scQuery)).EndInit();
			this._scQuery.ResumeLayout(false);
			this._scPublications.Panel1.ResumeLayout(false);
			this._scPublications.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._scPublications)).EndInit();
			this._scPublications.ResumeLayout(false);
			this._tcPublication.ResumeLayout(false);
			this._tpPublicationBibTeX.ResumeLayout(false);
			this._tpPublicationBibTeX.PerformLayout();
			this._tpPublicationInstance.ResumeLayout(false);
			this._cmsPublication.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip _msKontiki;
		private System.Windows.Forms.ToolStripMenuItem collectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip _stsKontiki;
		private System.Windows.Forms.ToolStrip _tsKontiki;
		private Gui.Controls.QueryControl _ctrlQuery;
		private System.Windows.Forms.SplitContainer _scCollection;
		private System.Windows.Forms.SplitContainer _scQuery;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.TreeView _tvCollection;
		private System.Windows.Forms.SplitContainer _scPublications;
		private System.Windows.Forms.TabControl _tcPublication;
		private System.Windows.Forms.TabPage _tpPublicationBibTeX;
		private System.Windows.Forms.TextBox _txPublicationBibTeX;
		private System.Windows.Forms.TabPage _tpPublicationInstance;
		private System.Windows.Forms.ContextMenuStrip _cmsCollection;
		private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteFolderToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip _cmsPublication;
		private System.Windows.Forms.ToolStripMenuItem addPublicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editPublicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deletePublicationToolStripMenuItem;
		private Gui.Controls.PublicationControl _ctrlPublication;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exportToClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bibTeXToolStripMenuItem;
		private System.Windows.Forms.ImageList _ilFolders;
		private System.Windows.Forms.ListView _lvPublications;
		private System.Windows.Forms.ColumnHeader PublicationId;
		private System.Windows.Forms.ColumnHeader Author;
		private System.Windows.Forms.ColumnHeader Title;
		private System.Windows.Forms.ColumnHeader Year;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}

