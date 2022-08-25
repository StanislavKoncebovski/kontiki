
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
			this._scCollection = new System.Windows.Forms.SplitContainer();
			this._tvCollection = new System.Windows.Forms.TreeView();
			this._cmsCollection = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._scQuery = new System.Windows.Forms.SplitContainer();
			this._scPublications = new System.Windows.Forms.SplitContainer();
			this._lbPublications = new System.Windows.Forms.ListBox();
			this._tcPublication = new System.Windows.Forms.TabControl();
			this._tpPublicationBibTeX = new System.Windows.Forms.TabPage();
			this._txPublicationBibTeX = new System.Windows.Forms.TextBox();
			this._tpPublicationInstance = new System.Windows.Forms.TabPage();
			this._cmsPublication = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addPublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editPublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deletePublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._ctrlQuery = new Kontiki.WF.Gui.Controls.QueryControl();
			this._msKontiki.SuspendLayout();
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
			this.newToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionNew);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionEdit);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionClose);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.loadToolStripMenuItem.Text = "&Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionLoad);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionSave);
			// 
			// saveasToolStripMenuItem
			// 
			this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
			this.saveasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.saveasToolStripMenuItem.Text = "Save &as";
			this.saveasToolStripMenuItem.Click += new System.EventHandler(this.OnCollectionSaveAs);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
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
			this._tsKontiki.Location = new System.Drawing.Point(0, 25);
			this._tsKontiki.Name = "_tsKontiki";
			this._tsKontiki.Size = new System.Drawing.Size(1237, 40);
			this._tsKontiki.TabIndex = 2;
			this._tsKontiki.Text = "toolStrip1";
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
			this._tvCollection.Location = new System.Drawing.Point(0, 0);
			this._tvCollection.Margin = new System.Windows.Forms.Padding(0);
			this._tvCollection.Name = "_tvCollection";
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
			this._scPublications.Panel1.Controls.Add(this._lbPublications);
			// 
			// _scPublications.Panel2
			// 
			this._scPublications.Panel2.Controls.Add(this._tcPublication);
			this._scPublications.Size = new System.Drawing.Size(530, 550);
			this._scPublications.SplitterDistance = 288;
			this._scPublications.TabIndex = 0;
			// 
			// _lbPublications
			// 
			this._lbPublications.ContextMenuStrip = this._cmsPublication;
			this._lbPublications.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lbPublications.FormattingEnabled = true;
			this._lbPublications.ItemHeight = 15;
			this._lbPublications.Location = new System.Drawing.Point(0, 0);
			this._lbPublications.Margin = new System.Windows.Forms.Padding(0);
			this._lbPublications.Name = "_lbPublications";
			this._lbPublications.Size = new System.Drawing.Size(530, 288);
			this._lbPublications.TabIndex = 0;
			this._lbPublications.SelectedIndexChanged += new System.EventHandler(this.OnPublicationSelected);
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
			this._tpPublicationInstance.Location = new System.Drawing.Point(4, 24);
			this._tpPublicationInstance.Name = "_tpPublicationInstance";
			this._tpPublicationInstance.Padding = new System.Windows.Forms.Padding(3);
			this._tpPublicationInstance.Size = new System.Drawing.Size(522, 230);
			this._tpPublicationInstance.TabIndex = 1;
			this._tpPublicationInstance.Text = "All";
			this._tpPublicationInstance.UseVisualStyleBackColor = true;
			// 
			// _cmsPublication
			// 
			this._cmsPublication.Font = new System.Drawing.Font("Consolas", 10F);
			this._cmsPublication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPublicationToolStripMenuItem,
            this.editPublicationToolStripMenuItem,
            this.deletePublicationToolStripMenuItem});
			this._cmsPublication.Name = "_cmsPublication";
			this._cmsPublication.Size = new System.Drawing.Size(221, 92);
			// 
			// addPublicationToolStripMenuItem
			// 
			this.addPublicationToolStripMenuItem.Name = "addPublicationToolStripMenuItem";
			this.addPublicationToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.addPublicationToolStripMenuItem.Text = "&Add Publication";
			this.addPublicationToolStripMenuItem.Click += new System.EventHandler(this.OnPublicationAdd);
			// 
			// editPublicationToolStripMenuItem
			// 
			this.editPublicationToolStripMenuItem.Name = "editPublicationToolStripMenuItem";
			this.editPublicationToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.editPublicationToolStripMenuItem.Text = "&Edit Publication";
			this.editPublicationToolStripMenuItem.Click += new System.EventHandler(this.OnPublicationEdit);
			// 
			// deletePublicationToolStripMenuItem
			// 
			this.deletePublicationToolStripMenuItem.Name = "deletePublicationToolStripMenuItem";
			this.deletePublicationToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.deletePublicationToolStripMenuItem.Text = "&Delete Publication";
			this.deletePublicationToolStripMenuItem.Click += new System.EventHandler(this.OnPublicationDelete);
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
		private System.Windows.Forms.ListBox _lbPublications;
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
	}
}

