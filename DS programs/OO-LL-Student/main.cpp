
#include <iostream>
#include "LinkedList.h"

int main()
{
	{
		LinkedList l1;
		Student shyam("Shyam", 23);
		Student gopal("Gopal", 24);
		Student nisha("Nisha", 25);

		l1.append(shyam);
		l1.append(gopal);
		l1.append(nisha);

		cout<<l1<<endl;				
		cout<<l1.getIDByName("Gopal")<<endl;
		cout<<l1.getNameByID(23)<<endl;
	}

}


