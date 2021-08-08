using System;

namespace Samples
{
	public class ForEach
	{
		public static void Main()
		{
			int[] integers = new int[5];
		
			for(int i = 0 ; i < 5; i++)
				integers[i] = i+1;

			foreach(int i in integers)		
				Console.WriteLine(i);
		}
	}
}