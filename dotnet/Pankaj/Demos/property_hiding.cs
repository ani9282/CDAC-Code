using System;

namespace Samples
{
	public class Base
	{
		private string _name;
		
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}
	}

	public class Derived : Base
	{
		private string _name;
		
		public new string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}		
	}

	public class TestApp
	{
		public static void Main()
		{
			Base ba = new Derived();

			ba.Name = "Sachin";
			Console.WriteLine(ba.Name);
		}
	}
}