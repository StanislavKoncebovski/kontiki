
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
			this._stsKontiki = new System.Windows.Forms.StatusStrip();
			this._tsKontiki = new System.Windows.Forms.ToolStrip();
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
			this._tlpKontiki = new System.Windows.Forms.TableLayoutPanel();
			this._ctrlQuery = new Kontiki.WF.Gui.Controls.QueryControl();
			this._msKontiki.SuspendLayout();
			this._tlpKontiki.SuspendLayout();
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
			this._msKontiki.Size = new System.Drawing.Size(1035, 25);
			this._msKontiki.TabIndex = 0;
			this._msKontiki.Text = "menuStrip1";
			// 
			// _stsKontiki
			// 
			this._stsKontiki.Location = new System.Drawing.Point(0, 510);
			this._stsKontiki.Name = "_stsKontiki";
			this._stsKontiki.Size = new System.Drawing.Size(1035, 22);
			this._stsKontiki.TabIndex = 1;
			this._stsKontiki.Text = "statusStrip1";
			// 
			// _tsKontiki
			// 
			this._tsKontiki.AutoSize = false;
			this._tsKontiki.ImageScalingSize = new System.Drawing.Size(38, 38);
			this._tsKontiki.Location = new System.Drawing.Point(0, 25);
			this._tsKontiki.Name = "_tsKontiki";
			this._tsKontiki.Size = new System.Drawing.Size(1035, 40);
			this._tsKontiki.TabIndex = 2;
			this._tsKontiki.Text = "toolStrip1";
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
			this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newToolStripMenuItem.Text = "&New";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			// 
			// saveasToolStripMenuItem
			// 
			this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
			this.saveasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveasToolStripMenuItem.Text = "Save &as";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			// 
			// _tlpKontiki
			// 
			this._tlpKontiki.ColumnCount = 3;
			this._tlpKontiki.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this._tlpKontiki.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this._tlpKontiki.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this._tlpKontiki.Controls.Add(this._ctrlQuery, 2, 0);
			this._tlpKontiki.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpKontiki.Location = new System.Drawing.Point(0, 65);
			this._tlpKontiki.Margin = new System.Windows.Forms.Padding(0);
			this._tlpKontiki.Name = "_tlpKontiki";
			this._tlpKontiki.RowCount = 1;
			this._tlpKontiki.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpKontiki.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._tlpKontiki.Size = new System.Drawing.Size(1035, 445);
			this._tlpKontiki.TabIndex = 3;
			// 
			// _ctrlQuery
			// 
			this._ctrlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this._ctrlQuery.Font = new System.Drawing.Font("Consolas", 10F);
			this._ctrlQuery.Location = new System.Drawing.Point(724, 0);
			this._ctrlQuery.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this._ctrlQuery.Name = "_ctrlQuery";
			this._ctrlQuery.Size = new System.Drawing.Size(308, 445);
			this._ctrlQuery.TabIndex = 0;
			// 
			// KontikiForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1035, 532);
			this.Controls.Add(this._tlpKontiki);
			this.Controls.Add(this._tsKontiki);
			this.Controls.Add(this._stsKontiki);
			this.Controls.Add(this._msKontiki);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.MainMenuStrip = this._msKontiki;
			this.Name = "KontikiForm";
			this.Text = "Kontiki 1.0";
			this._msKontiki.ResumeLayout(false);
			this._msKontiki.PerformLayout();
			this._tlpKontiki.ResumeLayout(false);
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
		private System.Windows.Forms.TableLayoutPanel _tlpKontiki;
		private Gui.Controls.QueryControl _ctrlQuery;
	}
}

