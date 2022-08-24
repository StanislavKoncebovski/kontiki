
namespace Kontiki.WF.Gui.Dialogs
{
	partial class ItemPropertiesDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPropertiesDialog));
			this._btOk = new System.Windows.Forms.Button();
			this._btCancel = new System.Windows.Forms.Button();
			this._tlpItemProperties = new System.Windows.Forms.TableLayoutPanel();
			this._lblDescription = new System.Windows.Forms.Label();
			this._lblName = new System.Windows.Forms.Label();
			this._txName = new System.Windows.Forms.TextBox();
			this._txDescription = new System.Windows.Forms.TextBox();
			this._tlpItemProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btOk
			// 
			this._btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btOk.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btOk.Location = new System.Drawing.Point(8, 224);
			this._btOk.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this._btOk.Name = "_btOk";
			this._btOk.Size = new System.Drawing.Size(120, 27);
			this._btOk.TabIndex = 0;
			this._btOk.Text = "OK";
			this._btOk.UseVisualStyleBackColor = true;
			this._btOk.Click += new System.EventHandler(this.OnOk);
			// 
			// _btCancel
			// 
			this._btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btCancel.Dock = System.Windows.Forms.DockStyle.Left;
			this._btCancel.Location = new System.Drawing.Point(136, 224);
			this._btCancel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this._btCancel.Name = "_btCancel";
			this._btCancel.Size = new System.Drawing.Size(120, 27);
			this._btCancel.TabIndex = 1;
			this._btCancel.Text = "Cancel";
			this._btCancel.UseVisualStyleBackColor = true;
			this._btCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// _tlpItemProperties
			// 
			this._tlpItemProperties.ColumnCount = 2;
			this._tlpItemProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
			this._tlpItemProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpItemProperties.Controls.Add(this._lblDescription, 0, 1);
			this._tlpItemProperties.Controls.Add(this._btCancel, 1, 3);
			this._tlpItemProperties.Controls.Add(this._lblName, 0, 0);
			this._tlpItemProperties.Controls.Add(this._btOk, 0, 3);
			this._tlpItemProperties.Controls.Add(this._txName, 1, 0);
			this._tlpItemProperties.Controls.Add(this._txDescription, 1, 1);
			this._tlpItemProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpItemProperties.Location = new System.Drawing.Point(0, 0);
			this._tlpItemProperties.Name = "_tlpItemProperties";
			this._tlpItemProperties.RowCount = 5;
			this._tlpItemProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this._tlpItemProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpItemProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this._tlpItemProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this._tlpItemProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this._tlpItemProperties.Size = new System.Drawing.Size(472, 259);
			this._tlpItemProperties.TabIndex = 2;
			// 
			// _lblDescription
			// 
			this._lblDescription.AutoSize = true;
			this._lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblDescription.Location = new System.Drawing.Point(3, 33);
			this._lblDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			this._lblDescription.Name = "_lblDescription";
			this._lblDescription.Size = new System.Drawing.Size(122, 183);
			this._lblDescription.TabIndex = 1;
			this._lblDescription.Text = "Description";
			this._lblDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _lblName
			// 
			this._lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this._lblName.AutoSize = true;
			this._lblName.Location = new System.Drawing.Point(3, 0);
			this._lblName.Name = "_lblName";
			this._lblName.Size = new System.Drawing.Size(40, 28);
			this._lblName.TabIndex = 0;
			this._lblName.Text = "Name";
			this._lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _txName
			// 
			this._txName.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txName.Location = new System.Drawing.Point(131, 3);
			this._txName.Name = "_txName";
			this._txName.Size = new System.Drawing.Size(338, 23);
			this._txName.TabIndex = 0;
			// 
			// _txDescription
			// 
			this._txDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txDescription.Location = new System.Drawing.Point(131, 31);
			this._txDescription.Multiline = true;
			this._txDescription.Name = "_txDescription";
			this._txDescription.Size = new System.Drawing.Size(338, 182);
			this._txDescription.TabIndex = 1;
			// 
			// ItemPropertiesDialog
			// 
			this.AcceptButton = this._btOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btCancel;
			this.ClientSize = new System.Drawing.Size(472, 259);
			this.Controls.Add(this._tlpItemProperties);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ItemPropertiesDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Project Properties";
			this._tlpItemProperties.ResumeLayout(false);
			this._tlpItemProperties.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btOk;
		private System.Windows.Forms.Button _btCancel;
		private System.Windows.Forms.TableLayoutPanel _tlpItemProperties;
		private System.Windows.Forms.Label _lblDescription;
		private System.Windows.Forms.Label _lblName;
		private System.Windows.Forms.TextBox _txName;
		private System.Windows.Forms.TextBox _txDescription;
	}
}