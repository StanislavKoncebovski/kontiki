/***********************************************************************************
* File:         PublicationControl.cs                                              *
* Contents:     Class PublicationControl                                           *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-25 12:30                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Windows.Forms;

namespace Kontiki.WF.Gui.Controls
{
	public partial class PublicationControl : UserControl
	{
		public PublicationControl()
		{
			InitializeComponent();

			this._pgPublication.PropertyValueChanged += this.OnPropertyValueChanged;
		}

		private void OnPropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			if (e.ChangedItem.PropertyDescriptor.Name == "Author" || e.ChangedItem.PropertyDescriptor.Name == "Year")
			{
				Publication publication				= this._pgPublication.SelectedObject as Publication;

				string id							= PublicationIdCreator.CreateId(publication);

				publication.Id						= id;

				this._pgPublication.SelectedObject	= publication;
			}
		}

		public Publication Publication
		{
			get
			{
				try
				{
					return this._pgPublication.SelectedObject as Publication;
				}
				catch
				{
					return null;
				}
			}

			set
			{
				this._pgPublication.SelectedObject = value;
			}
		}

		
	}
}
