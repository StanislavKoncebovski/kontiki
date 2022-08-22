
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
			this._msKontiki = new System.Windows.Forms.MenuStrip();
			this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this._ctrlQuery = new Kontiki.WF.Gui.Controls.QueryControl();
			this._scCollection = new System.Windows.Forms.SplitContainer();
			this._scQuery = new System.Windows.Forms.SplitContainer();
			this._msKontiki.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._scCollection)).BeginInit();
			this._scCollection.Panel2.SuspendLayout();
			this._scCollection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._scQuery)).BeginInit();
			this._scQuery.Panel2.SuspendLayout();
			this._scQuery.SuspendLayout();
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
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			// 
			// saveasToolStripMenuItem
			// 
			this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
			this.saveasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.saveasToolStripMenuItem.Text = "Save &as";
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
			// _ctrlQuery
			// 
			this._ctrlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ctrlQuery.Font = new System.Drawing.Font("Consolas", 10F);
			this._ctrlQuery.Location = new System.Drawing.Point(0, 0);
			this._ctrlQuery.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this._ctrlQuery.Name = "_ctrlQuery";
			this._ctrlQuery.Size = new System.Drawing.Size(544, 550);
			this._ctrlQuery.TabIndex = 0;
			// 
			// _scCollection
			// 
			this._scCollection.Dock = System.Windows.Forms.DockStyle.Fill;
			this._scCollection.Location = new System.Drawing.Point(0, 65);
			this._scCollection.Margin = new System.Windows.Forms.Padding(0);
			this._scCollection.Name = "_scCollection";
			// 
			// _scCollection.Panel2
			// 
			this._scCollection.Panel2.Controls.Add(this._scQuery);
			this._scCollection.Size = new System.Drawing.Size(1237, 550);
			this._scCollection.SplitterDistance = 412;
			this._scCollection.TabIndex = 4;
			// 
			// _scQuery
			// 
			this._scQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this._scQuery.Location = new System.Drawing.Point(0, 0);
			this._scQuery.Name = "_scQuery";
			// 
			// _scQuery.Panel2
			// 
			this._scQuery.Panel2.Controls.Add(this._ctrlQuery);
			this._scQuery.Size = new System.Drawing.Size(821, 550);
			this._scQuery.SplitterDistance = 273;
			this._scQuery.TabIndex = 0;
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
			this._scCollection.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._scCollection)).EndInit();
			this._scCollection.ResumeLayout(false);
			this._scQuery.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._scQuery)).EndInit();
			this._scQuery.ResumeLayout(false);
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
	}
}

