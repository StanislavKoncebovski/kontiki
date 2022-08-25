
namespace Kontiki.WF.Gui.Controls
{
	partial class PublicationControl
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
			this._pgPublication = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// _pgPublication
			// 
			this._pgPublication.Dock = System.Windows.Forms.DockStyle.Fill;
			this._pgPublication.Location = new System.Drawing.Point(0, 0);
			this._pgPublication.Margin = new System.Windows.Forms.Padding(0);
			this._pgPublication.Name = "_pgPublication";
			this._pgPublication.Size = new System.Drawing.Size(467, 462);
			this._pgPublication.TabIndex = 0;
			// 
			// PublicationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._pgPublication);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "PublicationControl";
			this.Size = new System.Drawing.Size(467, 462);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PropertyGrid _pgPublication;
	}
}
