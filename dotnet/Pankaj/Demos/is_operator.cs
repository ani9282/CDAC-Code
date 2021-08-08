using System;

namespace Samples
{
	class MyClass1 
	{
	}

	class MyClass2 
	{
	}

	public class IsTest 
	{

   		public static void Main() 
   		{
      			object [] myObjects = new object[6];

      			myObjects[0] = new MyClass1();
      			myObjects[1] = new MyClass2();
      			myObjects[2] = "hello";
      			myObjects[3] = 123;
		      	myObjects[4] = 123.4;
      			myObjects[5] = null;

      			for (int i=0; i<myObjects.Length; ++i) 
      			{
         			string s = myObjects[i] as string;
         			Console.Write ("{0}:", i);

         			if (s != null)
            				Console.WriteLine ( "'" + s + "'" );
         			else
            				Console.WriteLine ( "not a string" );
      			}
   		}
	}

}