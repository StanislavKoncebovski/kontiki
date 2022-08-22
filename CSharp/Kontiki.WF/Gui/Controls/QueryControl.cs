/***********************************************************************************
* File:         QueryControl.cs                                                    *
* Contents:     Class QueryControl                                                 *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-22 20:42                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontiki.WF.Gui.Controls
{
	public partial class QueryControl : UserControl
	{
		public QueryControl()
		{
			InitializeComponent();

			this._cxQueryParameters.DataSource = Enum.GetValues(typeof(QueryColumn));
			this._cxQueryParameters.SelectedItem = QueryColumn.Default;

			this._cxPublicationType.Items.AddRange(new string[] {"Book", "Article"});
			this._cxPublicationType.SelectedItem = "Book";

			// TODO Move to settings
			this._cxSource.Items.Add("LibGen");
			this._cxSource.SelectedItem = "LibGen";
		}

		private void OnStartQuery(object sender, EventArgs e)
		{
			if (this._cxPublicationType.SelectedItem.ToString() == "Book")
			{
				List<Publication> books = KontikiForm.KontikiManager.QueryBooks(this._txTokens.Text, (QueryColumn)this._cxQueryParameters.SelectedItem);
			}
		}
	}
}
