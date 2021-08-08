using System;
using System.Text;

namespace Samples
{
	public class StringBuilderTest
	{
		public static void Main(string[] args)
		{
			StringBuilder sb = new StringBuilder();
		 
			for(int i = 0 ; i < 10 ; i++) 		
				sb.Append(i.ToString() + "\t");		
		
			for(int i = 0 ; i < sb.Length; i++)
				Console.WriteLine(sb[i].ToString());		

			Console.WriteLine(sb.ToString());
		}
	}
}


// Compilation Process:
// csc stringbuilder.cs
// stringbuilder