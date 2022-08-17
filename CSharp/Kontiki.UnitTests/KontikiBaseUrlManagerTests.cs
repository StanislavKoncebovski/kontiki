using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
	}
}
