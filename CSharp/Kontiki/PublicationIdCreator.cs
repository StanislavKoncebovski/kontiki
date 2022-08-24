/***********************************************************************************
* File:         PublicationIdCreator.cs                                            *
* Contents:     Class PublicationIdCreator                                         *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-24 21:01                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kontiki.Tools;

namespace Kontiki
{
	public static class PublicationIdCreator
	{
		public static string CreateId(Publication publication)
		{
			string author = String.IsNullOrEmpty(publication.Author)? "sine_nomine" : publication.Author;
			string address = String.IsNullOrEmpty(publication.Address)? "sine_loco" : publication.Address;
			string year = String.IsNullOrEmpty(publication.Year)? "sine_anno" : publication.Year;

			return "";
		}

		public static string GetPrimaryAuthor(string authors)
		{
			if (authors.Length <= 2)
			{
				return "sine_nomine";
			}

			string[] items = authors.Split(',');

			if (items.Length > 0)
			{
				string[] cells = items[0].Split(' ');

				if (cells.Length > 0)
				{
					string firstItem	= cells[0].Trim().ToLower();
					string lastItem		= cells[cells.Length - 1].Trim().ToLower();

					bool selectLast		= true;
					if (lastItem.EndsWith("."))
					{
						selectLast		= false;
					}

					return selectLast? lastItem.ToCapital() : firstItem.ToCapital();
				}
				else
				{
					return "sine_nomine";
				}
			}
			else
			{
				return "sine_nomine";
			}
		}
	}
}
