using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontiki.WF.Gui.Dialogs
{
	public partial class PublicationDialog : Form
	{
		public PublicationDialog()
		{
			InitializeComponent();
		}

		private void OnOk(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnCancel(object sender, EventArgs e)
		{

		}

		public Publication Publication
		{
			get
			{
				return this._ctrlPublication.Publication;
			}

			set
			{
				this._ctrlPublication.Publication = value;
			}
		}
	}
}
