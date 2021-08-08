
#include"Queue.h"

int main()
{

	int n,no,y;
	

	cout<<"\n Enter size of queue you want :";
	cin>>y;
	queue q1(y);

	do{
	
		cout<<"\n1.Insert No:\n2.Delete No:\n3.Display Queue :\n4.Exit\nEnter what you want to do:";
		cin>>n;
		switch(n)
		{
		case 1:
		
			cout<<"\nEnter a number:";
			cin>>no;
			q1.enqueue(no);
			break;
	
		case 2:
			cout<<"\nDequeue:"<<q1.dequeue()<<"\n";
			break;

		case 3:
			q1.display();
			break;
			
		}
	}
	while(n!=4);
}
