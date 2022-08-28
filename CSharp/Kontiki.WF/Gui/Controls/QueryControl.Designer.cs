
namespace Kontiki.WF.Gui.Controls
{
	partial class QueryControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._tlpQueryControl = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this._cxQueryParameters = new System.Windows.Forms.ComboBox();
			this._cxPublicationType = new System.Windows.Forms.ComboBox();
			this._btAddSelected = new System.Windows.Forms.Button();
			this._btCancel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._btStartQuery = new System.Windows.Forms.Button();
			this._pgQuery = new System.Windows.Forms.ProgressBar();
			this._cxSource = new System.Windows.Forms.ComboBox();
			this._txTokens = new System.Windows.Forms.TextBox();
			this._clbQueryResults = new System.Windows.Forms.CheckedListBox();
			this._tlpQueryControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tlpQueryControl
			// 
			this._tlpQueryControl.ColumnCount = 3;
			this._tlpQueryControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this._tlpQueryControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tlpQueryControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tlpQueryControl.Controls.Add(this.label4, 0, 3);
			this._tlpQueryControl.Controls.Add(this._cxQueryParameters, 1, 2);
			this._tlpQueryControl.Controls.Add(this._cxPublicationType, 1, 1);
			this._tlpQueryControl.Controls.Add(this._btAddSelected, 1, 7);
			this._tlpQueryControl.Controls.Add(this._btCancel, 2, 4);
			this._tlpQueryControl.Controls.Add(this.label3, 0, 2);
			this._tlpQueryControl.Controls.Add(this.label2, 0, 1);
			this._tlpQueryControl.Controls.Add(this.label1, 0, 0);
			this._tlpQueryControl.Controls.Add(this._btStartQuery, 1, 4);
			this._tlpQueryControl.Controls.Add(this._pgQuery, 1, 5);
			this._tlpQueryControl.Controls.Add(this._cxSource, 1, 0);
			this._tlpQueryControl.Controls.Add(this._txTokens, 1, 3);
			this._tlpQueryControl.Controls.Add(this._clbQueryResults, 0, 6);
			this._tlpQueryControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpQueryControl.Location = new System.Drawing.Point(0, 0);
			this._tlpQueryControl.Margin = new System.Windows.Forms.Padding(0);
			this._tlpQueryControl.Name = "_tlpQueryControl";
			this._tlpQueryControl.RowCount = 8;
			this._tlpQueryControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpQueryControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpQueryControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpQueryControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpQueryControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this._tlpQueryControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpQueryControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpQueryControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this._tlpQueryControl.Size = new System.Drawing.Size(467, 462);
			this._tlpQueryControl.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(0, 96);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 32);
			this.label4.TabIndex = 11;
			this.label4.Text = "Token(s)";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _cxQueryParameters
			// 
			this._tlpQueryControl.SetColumnSpan(this._cxQueryParameters, 2);
			this._cxQueryParameters.Dock = System.Windows.Forms.DockStyle.Fill;
			this._cxQueryParameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cxQueryParameters.FormattingEnabled = true;
			this._cxQueryParameters.Location = new System.Drawing.Point(160, 69);
			this._cxQueryParameters.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this._cxQueryParameters.Name = "_cxQueryParameters";
			this._cxQueryParameters.Size = new System.Drawing.Size(307, 23);
			this._cxQueryParameters.TabIndex = 2;
			// 
			// _cxPublicationType
			// 
			this._tlpQueryControl.SetColumnSpan(this._cxPublicationType, 2);
			this._cxPublicationType.Dock = System.Windows.Forms.DockStyle.Fill;
			this._cxPublicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cxPublicationType.FormattingEnabled = true;
			this._cxPublicationType.Location = new System.Drawing.Point(160, 37);
			this._cxPublicationType.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this._cxPublicationType.Name = "_cxPublicationType";
			this._cxPublicationType.Size = new System.Drawing.Size(307, 23);
			this._cxPublicationType.TabIndex = 1;
			// 
			// _btAddSelected
			// 
			this._tlpQueryControl.SetColumnSpan(this._btAddSelected, 2);
			this._btAddSelected.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btAddSelected.Image = global::Kontiki.WF.Properties.Resources.AddSelected_Dark;
			this._btAddSelected.Location = new System.Drawing.Point(160, 422);
			this._btAddSelected.Margin = new System.Windows.Forms.Padding(0);
			this._btAddSelected.Name = "_btAddSelected";
			this._btAddSelected.Size = new System.Drawing.Size(307, 40);
			this._btAddSelected.TabIndex = 8;
			this._btAddSelected.Text = "&Add Selected";
			this._btAddSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._btAddSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btAddSelected.UseVisualStyleBackColor = true;
			this._btAddSelected.Click += new System.EventHandler(this.OnAddSelectedPublications);
			// 
			// _btCancel
			// 
			this._btCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btCancel.Enabled = false;
			this._btCancel.Image = global::Kontiki.WF.Properties.Resources.QueryStop_Dark;
			this._btCancel.Location = new System.Drawing.Point(313, 128);
			this._btCancel.Margin = new System.Windows.Forms.Padding(0);
			this._btCancel.MinimumSize = new System.Drawing.Size(0, 32);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new System.Drawing.Size(154, 40);
			this._btCancel.TabIndex = 5;
			this._btCancel.Text = "&Cancel";
			this._btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btCancel.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(0, 64);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Query by";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(0, 32);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Publication Type";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _btStartQuery
			// 
			this._btStartQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btStartQuery.Image = global::Kontiki.WF.Properties.Resources.QueryStart_Dark;
			this._btStartQuery.Location = new System.Drawing.Point(160, 128);
			this._btStartQuery.Margin = new System.Windows.Forms.Padding(0);
			this._btStartQuery.MinimumSize = new System.Drawing.Size(0, 32);
			this._btStartQuery.Name = "_btStartQuery";
			this._btStartQuery.Size = new System.Drawing.Size(153, 40);
			this._btStartQuery.TabIndex = 4;
			this._btStartQuery.Text = "&Start";
			this._btStartQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._btStartQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btStartQuery.UseVisualStyleBackColor = true;
			this._btStartQuery.Click += new System.EventHandler(this.OnStartQuery);
			// 
			// _pgQuery
			// 
			this._tlpQueryControl.SetColumnSpan(this._pgQuery, 2);
			this._pgQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this._pgQuery.Location = new System.Drawing.Point(163, 171);
			this._pgQuery.MinimumSize = new System.Drawing.Size(0, 32);
			this._pgQuery.Name = "_pgQuery";
			this._pgQuery.Size = new System.Drawing.Size(301, 32);
			this._pgQuery.TabIndex = 6;
			// 
			// _cxSource
			// 
			this._tlpQueryControl.SetColumnSpan(this._cxSource, 2);
			this._cxSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this._cxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cxSource.FormattingEnabled = true;
			this._cxSource.Location = new System.Drawing.Point(160, 5);
			this._cxSource.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this._cxSource.Name = "_cxSource";
			this._cxSource.Size = new System.Drawing.Size(307, 23);
			this._cxSource.TabIndex = 0;
			// 
			// _txTokens
			// 
			this._tlpQueryControl.SetColumnSpan(this._txTokens, 2);
			this._txTokens.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txTokens.Location = new System.Drawing.Point(160, 101);
			this._txTokens.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this._txTokens.Name = "_txTokens";
			this._txTokens.Size = new System.Drawing.Size(307, 23);
			this._txTokens.TabIndex = 3;
			// 
			// _clbQueryResults
			// 
			this._tlpQueryControl.SetColumnSpan(this._clbQueryResults, 3);
			this._clbQueryResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this._clbQueryResults.Font = new System.Drawing.Font("Arial", 9F);
			this._clbQueryResults.Location = new System.Drawing.Point(0, 208);
			this._clbQueryResults.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this._clbQueryResults.Name = "_clbQueryResults";
			this._clbQueryResults.Size = new System.Drawing.Size(467, 214);
			this._clbQueryResults.TabIndex = 7;
			// 
			// QueryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._tlpQueryControl);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "QueryControl";
			this.Size = new System.Drawing.Size(467, 462);
			this._tlpQueryControl.ResumeLayout(false);
			this._tlpQueryControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _tlpQueryControl;
		private System.Windows.Forms.Button _btAddSelected;
		private System.Windows.Forms.Button _btCancel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _btStartQuery;
		private System.Windows.Forms.ProgressBar _pgQuery;
		private System.Windows.Forms.ComboBox _cxQueryParameters;
		private System.Windows.Forms.ComboBox _cxPublicationType;
		private System.Windows.Forms.ComboBox _cxSource;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _txTokens;
		private System.Windows.Forms.CheckedListBox _clbQueryResults;
	}
}
