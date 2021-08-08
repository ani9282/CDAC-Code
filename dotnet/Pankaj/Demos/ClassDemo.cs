
using System;
namespace classDemo
{
	class Address
	{
		string houseNo;
		string aptName;
		string locality;
		string city;
		string state;
		
	}
	
	class Student
	{
		//Fields
		int rollNo;
		string name;
		DateTime adDate;
		Address homeAddr;//UDT
		
		//Properties
		
		public int RollNo
		{
			get
			{
				return rollNo;
			}
			set
			{
				rollNo=value;
			}
		}
		
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name=value;
			}
		}
		
		public Address HomeAddr
		{
			get
			{
				return homeAddr;
			}
			set
			{
				homeAddr=value;
			}
		}
		//Methods
		public Student()
		{
			rollNo=100;
			name="xyz";
			adDate=DateTime.Now;
		}
		
		public void GetStudDetails()
		{
			Console.WriteLine("Roll No :"+rollNo);
			Console.WriteLine("Name :"+name);
			Console.WriteLine("Date of Addmission :"+adDate);
		}
	}
	
	class Standard
	{
		Student[] s1;
		public Standard()
		{
			s1=new Student[5];
		}
		public Standard(int size)
		{
			s1=new Student[size];
		}
		~Standard()
		{
			s1=null;
		}
	}
	
	
	class School
	{
		static void Main()
		{
			Student s1=new Student();
			s1.GetStudDetails();
			Console.ReadLine();
		}
	}
}