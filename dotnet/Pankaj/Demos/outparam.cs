using System;

namespace Samples
{
	public class OutParam
	{
		public void CallMe()
		{
			int a;

			Fill(out a);

			Console.WriteLine(a);
		}

		public void Fill(out int b)
		{
			b = 10;
		}

		public static void Main()
		{	
			OutParam outPar = new OutParam();

			outPar.CallMe();
            Console.ReadLine();
		}
	}
}