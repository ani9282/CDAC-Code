

#include "CQueue.h"

int main()
{

	cout<<"*********** char type ***********"<<endl;
	{
		CQueue<char> q1;
		q1.enqueue('A');
		q1.enqueue('B');
		q1.enqueue('C');
		q1.enqueue('D');
		q1.enqueue('X');
		q1.displayQueue();
		q1.dequeue();
		q1.displayQueue();
	}


	cout<<"*********** int type ***********"<<endl;
	{
		CQueue<int> q1;
		q1.enqueue(10);
		q1.enqueue(20);
		q1.enqueue(30);
		q1.enqueue(40);
		q1.enqueue(50);
		q1.displayQueue();
		q1.dequeue();
		q1.displayQueue();
	}
}


