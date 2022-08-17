/***********************************************************************************
* File:         KontikiBaseUrlManagerTests.cs                                      *
* Contents:     Class KontikiBaseUrlManagerTests                                   *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-17 23:08                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Kontiki.UnitTests
{
	[TestFixture]
	public class KontikiBaseUrlManagerTests
	{
		[Test]
		public void TestingBaseUrl_ValidbaseUrl_Succeeds()
		{
			KontikiBaseUrl baseUrl = new KontikiBaseUrl("default", "http://libgen.rs/");

			KontikiBaseUrlManager manager = new KontikiBaseUrlManager();

			manager.TestBaseUrl(baseUrl);

			Assert.That(baseUrl.IsOnline);

			Console.WriteLine(baseUrl.ConnectionTime);
		}

		[Test]
		public void TestingBaseUrl_InvalidbaseUrl_Succeeds()
		{
			KontikiBaseUrl baseUrl = new KontikiBaseUrl("default_x", "http://libgen.rx/");

			KontikiBaseUrlManager manager = new KontikiBaseUrlManager();

			manager.TestBaseUrl(baseUrl);

			Assert.That(!baseUrl.IsOnline);
		}

		[Test]
		public void ConversionToXmlSucceeds()
		{
			KontikiBaseUrlManager manager = new KontikiBaseUrlManager();
			//KontikiBaseUrl baseUrl = new KontikiBaseUrl("default", "http://libgen.rs/");
			//manager.TestBaseUrl(baseUrl);

			//manager.AddBaseUrl(baseUrl);

			//manager.Save("baseUrls.xml");


			Dictionary<string, string>	baseUrls = new Dictionary<string, string>()
			{
				{"Default", "http://libgen.rs/"},
				{"Proxy01", "https://freeanimesonline.com/proxify.php?proxy=ZnJlZWFuaW1lc29ubGluZS5jb20=&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
				{"Proxy02",	"https://sitenable.info/proxify.php?proxy=c2l0ZW5hYmxlLmluZm8=&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
				{"Proxy03", "https://siteget.net/proxify.php?proxy=c2l0ZWdldC5uZXQ=&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
				{"Proxy04", "https://freeproxy.io/proxify.php?proxy=ZnJlZXByb3h5Lmlv&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
				{"Proxy05", "https://sitenable.co/proxify.php?proxy=c2l0ZW5hYmxlLmNv&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
				{"Proxy06", "https://sitenable.ch/proxify.php?proxy=c2l0ZW5hYmxlLmNo&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
				{"Proxy07", "https://sitenable.pw/proxify.php?proxy=c2l0ZW5hYmxlLnB3&amp;site=aHR0cDovL2dlbi5saWIucnVzLmVjLw=="},
			};

			foreach (string name in baseUrls.Keys)
			{
				KontikiBaseUrl baseUrl = new KontikiBaseUrl(name, baseUrls[name]);
				manager.TestBaseUrl(baseUrl);

				manager.AddBaseUrl(baseUrl);
			}

			manager.Save("baseUrls.xml");
		}
	}
}
