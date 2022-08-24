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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Kontiki.Collection;
using Kontiki.Tools;

namespace Kontiki
{
	public static class PublicationIdCreator
	{
		#region Public Properties
		public static KontikiCollection Collection {get;set;} = null;
		#endregion

		public static string CreateId(Publication publication)
		{
			string author	= GetPrimaryAuthor(publication.Author);
			string address	= String.IsNullOrEmpty(publication.Address)? "sl" : publication.Address;
			string year		= String.IsNullOrEmpty(publication.Year)? "sa" : publication.Year;

			string result	= $"{author}_{year}";

			if (Collection != null)
			{
				string[] ids = Collection.GetPublicationIds();

				if (ids.Contains(result))
				{
					string[] ids_subset = ids.Where(i => i.StartsWith(result)).ToArray();
					result = result += $"_{ids_subset.Length}";
				}
			}

			return result;
		}

		private static string GetPrimaryAuthor(string authors)
		{
			if (authors.Length <= 2)
			{
				return "sn";
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
					return "sn";
				}
			}
			else
			{
				return "sn";
			}
		}
	}
}
