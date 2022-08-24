/***********************************************************************************
* File:         PublicationIdCreatorTests.cs                                       *
* Contents:     Class PublicationIdCreatorTests                                    *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-24 21:08                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kontiki.UnitTests
{
	[TestFixture]
	class PublicationIdCreatorTests
	{
		[Test]
		public void PrimaryAuthorExctraction_Succeeds()
		{
			string[] author_strings = new string[]
			{
				"Jesaya Krumm",
				"Francis E. Low",
				"Lynne Cameron, Graham Low",
				"Marcus Smith, Seumas Miller",
				"Axel Körner, Nicola Miller, Adam I. P. Smith (eds.)",
				"Prof. Dr.-Ing. Dres. h.c. Herwart Opitz, Prof. Dr.-Ing. Manfred Weck, Dr.-Ing. Peter Bagh (auth.)",
				"",
				"RAFAEL RUIZ ARANGO, Q.F.",
				"Abramowitz M., Stegun I.A. (eds.)",
				"Laurent Abramowitz, Matthieu Allez, Franck Devulder, Jean-Luc Faucheron, Roland Ganansia, Denis Soudan, Anne-Laure Tarrerias (auth.)",
			};

			foreach (string author_string in author_strings)
			{
				string primaryAuthor = PublicationIdCreator.GetPrimaryAuthor(author_string);
			}
		}
	}
}
