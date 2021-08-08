#include<iostream>
#include<ostream>
using namespace std;
#include"LinkList.h"
int main()
{
	{
		LinkList l1;
		Student s("Shyam", 23);
		Student gopal("Gopal", 24);
		Student nisha("Nisha", 25);

		l1.insert(s);
		cout<<l1<<endl;
		l1.insert(gopal);
		
		l1.insert(nisha);
		cout<<l1<<endl;
				
				
				
		cout<<l1.getIdbyname("Gopal")<<endl;
		cout<<l1.getIdbyname("Nisha")<<endl;
		cout<<l1.getNameByID(23)<<endl;
	}

}


