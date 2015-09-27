/*
 * Created by SharpDevelop.
 * User: manu
 * Date: 9/27/2015
 * Time: 10:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Timers;

namespace Algoithms
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