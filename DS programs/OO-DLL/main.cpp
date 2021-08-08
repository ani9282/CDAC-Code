
#include "DLinkedList.h"


int main()
{
	DLinkedList l1;
	int i;
	for(i=0;i<15;i++)
	{
		if(i%2==0)
		{
			l1.insert(i);
			cout<<l1<<endl;
		}
		else
		{
			l1.append(i);
			cout<<l1<<endl;
		}
	}

	for(i=0;i<10;i++)
	{
		if(i%2==0)
		{
			l1.deleteFirst();
			cout<<l1<<endl;
		}
		else
		{
			l1.deleteLast();
			cout<<l1<<endl;
		}
	}

	cout<<l1<<endl;
	cout<<l1[5]<<endl;	


	/*{
		DLinkedList l2(l1);
		cout<<"==================="<<endl;
		cout<<l2<<endl;

		cout<<"=========RP========"<<endl;
		l2.reversePrint();

		cout<<"==================="<<endl;
		cout<<l2<<endl;
		cout<<l2<<endl;
		cout<<l2<<endl;
		
	}
*/	
	
}





