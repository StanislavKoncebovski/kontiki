/***********************************************************************************
* File:         KontikiCollectionDialog.cs                                         *
* Contents:     Class KontikiCollectionDialog                                      *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-24 12:08                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Kontiki.WF.Gui.Dialogs
{
	public partial class ItemPropertiesDialog : Form
	{
		public ItemPropertiesDialog()
		{
			InitializeComponent();
			this._txName.Select();
		}

		private void OnOk(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnCancel(object sender, EventArgs e)
		{

		}

		public string ItemName
		{
			get
			{
				return this._txName.Text;
			}

			set
			{
				this._txName.Text = value;
			}
		}

		public string ItemDescription
		{
			get
			{
				return this._txDescription.Text;
			}

			set
			{
				this._txDescription.Text = value;
			}
		}
	}
}
