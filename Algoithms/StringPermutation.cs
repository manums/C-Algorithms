/*
 * Created by SharpDevelop.
 * User: manu
 * Date: 9/27/2015
 * Time: 10:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Algoithms
{
	/// <summary>
	/// Description of StringPermutation.
	/// </summary>
	public class StringPermutation
	{
		public StringPermutation()
		{
		}
		
		//This is recursive one too, however we use extra space for intermittent strings, esp too much of concatenation 
		//causing too many intermittent string and also every run will creates intermittent string while updating pre fixed string w
		//idea is to get letter at char i, take that as first char of permutated strings and then pick chars in the remaining substring for each index
		// append them to pre like in abcd -> when index is 0 pre becomes a, bcd becomes str to permute
		// in next run where bcd is substring, index can move from b to d
		// thus creating pre = ab, str=>cd, pre=> ac, str =>bd, pre=>ad str=> bc premutation in branches
		//in example where pre=>ad, str=>bc.. in for index [0] to [1] i.e.b to c
		//pre becomes adb , str becomes c for next recursion and in other branch pre becomes adc, str is left with b
		// in branch where pre is adc, str is left b, i=0 branch has only one char left in str=b and hence thats get added to pre =>adcb
		// call permutation with str ="" and hence that recursion branch ends there printing pre which is adcb
		public static void Permute(string str, string pre)
		{
			if(str.Length<=0)
			{
				Console.WriteLine(pre);
				return;
			}
			for(int i =0; i<str.Length; i++)
			{
				Permute(str.Substring(0,i) + str.Substring(i+1), pre+ str[i]);
			}		
			
		}
		
		/*In abcd, during first run
		 in for each letter of str gets swapped with first letter of str i.e.
		 in abcd there will separate branches of permuatation for abcd, bacd, cbad,dbca
		 for each of these permutations when index is incremented, we keep chars till previous index as fixed 
		 and swap incremented index with char at i
		 it is essentially same in dbca, keeping d fixed and now permuting bca and in next run we will have permute branches for dbca, dcba,dabc
		 and in next steps for eg in dcba branch, it is about keeping dc fixed cos the index is at 2 and str left to permute is only bc in dbca
		 Thus its about keeping initial char fixed and permuting remaining substring by again by following the same permutation steps */
		public static void RecursivePermute(char[] str, int index)
		{
			if(index == str.Length - 1)
			{
				Console.WriteLine(str);
				return;
			}
			for(int i = index; i<str.Length; i++)
			{
				//swap letters and i and index
				
				var temp = str[i];
				str[i] = str[index];
				str[index] = temp;
				RecursivePermute(str,index + 1);
				//Backtracking to get the string to unswapped state before this iteration
				
				temp = str[i];
				str[i] = str[index];
				str[index] = temp;
			}		
			
		}
	}
}
