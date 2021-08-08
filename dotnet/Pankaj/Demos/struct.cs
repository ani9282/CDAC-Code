using System;

namespace Samples
{
	struct Item
	{
		private int _no;

		public int No
		{
			get
			{
				return _no;
			}

			set
			{
				_no = value;
			}
		}
	}

	public class TestApp
	{

		public static int Main()
		{
			Item it = new Item();
		
			Console.WriteLine("Enter Any No : ");
			it.No = int.Parse(Console.ReadLine().ToString());
			Console.WriteLine("No : {0} ",it.No);

			return 0;
		}
	}

}