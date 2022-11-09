using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}
	public static class StringLeft
		{
			public static string Left(this string source, int leagth)
			{
				if(string.IsNullOrEmpty(source)) return string.Empty;
				if(source.Length <= 0) return string.Empty;
				if(source.Length<leagth) return string.Empty;
				return source.Substring(0, leagth);
			}

		}
}
