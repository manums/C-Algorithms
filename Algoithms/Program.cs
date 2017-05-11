using Algorithms.Strings;
using System;
using System.Diagnostics;
using System.Timers;

namespace Algorithms
{
	class Program
	{
		public static void Main(string[] args)
		{
			DateTime start = DateTime.Now;
	
			StringPermutation.Permute("abcde", "");
			DateTime end = DateTime.Now;
			
			Console.WriteLine((end-start).Milliseconds);
			start = DateTime.Now;
			StringPermutation.RecursivePermute("abcde".ToCharArray(), 0);
			end = DateTime.Now;
			
			Console.WriteLine((end-start).Milliseconds);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}