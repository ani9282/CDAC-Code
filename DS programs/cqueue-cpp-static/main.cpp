


#include "Queue.h"

int main()
{

	Queue q1;
	q1.enqueue(10);
	q1.enqueue(20);
	q1.enqueue(30);
	q1.enqueue(40);
	q1.enqueue(50);
	cout<<q1<<endl;
	q1.dequeue();
	cout<<q1<<endl;

	q1<<58;
	cout<<q1<<endl;
	//q1.operator<<(int)

	Queue q2=q1;
	cout<<q2<<endl;	
	q2.dequeue();
	cout<<q2<<endl;	


	Queue q3=q1+q2;
	cout<<q3<<endl;	

}


