using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "aaaa";
			Console.WriteLine(value.ToInt(-1));
			string value2 = "123456";
			Console.WriteLine(value.ToInt(0));


		}
	}
	public static class StringExtensions
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool isValue = int.TryParse(value, out int result);
			return isValue ? result : defaultValue;
		}
	}
}
