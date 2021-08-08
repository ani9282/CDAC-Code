using System;

namespace Eurofins
{
	class Developer
	{
		public int DevId{get;set;}
		public string DevName{get;set;}
        
	}
	class Project
	{
		public int ProjId{get;set;}
		public string ProjName{get;set;}
		
		Developer[] onSiteDev=null;
		public Project()
		{
			onSiteDev=new Developer[5];
		}
		//Creating Indexer 
		public Developer this[int index]
		{
			get
			{
				return onSiteDev[index];
			}
			set
			{
				onSiteDev[index]=value;
			}
		}
		
	}
	class IndexerDemo
	{
		static void Main()
		{
			// Creating Instance of Developers
			Developer dev1,dev2,dev3,dev4;
			
			dev1=new Developer();
			dev2=new Developer();
			dev3=new Developer();
			dev4=new Developer();
			
			//Assigning Data to Members of Dev Object.
			dev1.DevId=1;
			dev1.DevName="Alok";
			
			dev2.DevId=2;
			dev2.DevName="Ali";
			
			dev3.DevId=3;
			dev3.DevName="Aliya";
			
			dev4.DevId=4;
			dev4.DevName="Prateek";
			
			//Creating Project Object
			
			Project  hsbcProj=new Project();
			
			hsbcProj.ProjId=101;
			hsbcProj.ProjName="HSBC Bank Project";
			
			//Using Indexer on Project
			
			hsbcProj[0]=dev1;
			hsbcProj[1]=dev2;
			hsbcProj[2]=dev3;
			hsbcProj[3]=dev4;
			hsbcProj[4]=new Developer();
			
				for(int i = 0; i < 5; i++)
				{
				Console.WriteLine(hsbcProj[i].DevName);
				}
			
			
			
		}
	}
}