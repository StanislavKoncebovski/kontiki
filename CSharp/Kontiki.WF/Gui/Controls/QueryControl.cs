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
		public event Action<Publication[]> PublicationsSelected;

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
			if (!KontikiForm.KontikiManager.ConnectionManager.WorkingConnection.IsOnline)
			{
				MessageBox.Show("Default connection is NOT online");
				return;
			}

			if (this._txTokens.Text.Length < 2)
			{
				MessageBox.Show("No valid query token", "Cannot carry out query", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}

			if (this._cxPublicationType.SelectedItem.ToString() == "Book")
			{
				this.Cursor = Cursors.WaitCursor;

				List<Publication> books = KontikiForm.KontikiManager.QueryBooks(this._txTokens.Text, (QueryColumn)this._cxQueryParameters.SelectedItem);

				if (books == null)
				{
					return;
				}

				this._clbQueryResults.Items.Clear();

				foreach (Publication book in books)
				{
					this._clbQueryResults.Items.Add(book);
				}

				this.Cursor = Cursors.Default;
			}
		}

		private void OnAddSelectedPublications(object sender, EventArgs e)
		{
			Publication[] selectedPublications	 = this._clbQueryResults.CheckedItems.OfType<Publication>().ToArray();

			this.PublicationsSelected?.Invoke(selectedPublications);
		}
	}
}
