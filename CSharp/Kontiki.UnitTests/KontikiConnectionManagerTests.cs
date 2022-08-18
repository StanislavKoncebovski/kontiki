/***********************************************************************************
* File:         KontikiConnectionManagerTests.cs                                   *
* Contents:     Class KontikiConnectionManagerTests                                *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-08-18 12:09                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Kontiki.UnitTests
{
	[TestFixture]
	public class KontikiConnectionManagerTests
	{
		[Test]
		public void TestingConnection_ValidConnection_Succeeds()
		{
			KontikiConnection connection = new KontikiConnection("default", "http://libgen.rs/");

			KontikiConnectionManager manager = new KontikiConnectionManager();

			manager.TestConnection(connection);

			Assert.That(connection.IsOnline);

			Console.WriteLine(connection.ConnectionTime);
		}

		[Test]
		public void TestingBaseUrl_InvalidbaseUrl_Succeeds()
		{
			KontikiConnection connection = new KontikiConnection("default_x", "http://libgen.rx/");

			KontikiConnectionManager manager = new KontikiConnectionManager();

			manager.TestConnection(connection);

			Assert.That(!connection.IsOnline);
		}

		[Test]
		public void ConversionToXmlSucceeds()
		{
			KontikiConnectionManager manager = new KontikiConnectionManager();

			Dictionary<string, string>	connections = new Dictionary<string, string>()
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

			foreach (string name in connections.Keys)
			{
				KontikiConnection connection = new KontikiConnection(name, connections[name]);
				manager.TestConnection(connection);

				manager.AddConnection(connection);
			}

			manager.Save("kontiki_connections.xml");
		}
	}
}
