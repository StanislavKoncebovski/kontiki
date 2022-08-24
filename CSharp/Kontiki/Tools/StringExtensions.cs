using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontiki.Tools
{
	public static class StringExtensions
	{
		public static string ToCapital(this string source)
		{
			if (source == null)
			{
				return null;
			}

			if (source.Length < 1)
			{
				return "";
			}

			return char.ToUpper(source[0]) + source.Substring(1);
		}
	}
}
