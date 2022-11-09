using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}
	public static class Math
	{
		public static bool IsOdd(this int source)
		{
			return source % 2 == 1;		
		}
		public static bool IsEven(this int soruce)
		{ 
			return soruce % 2 == 0;
		}
	

	}
	
}
