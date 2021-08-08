
#include <stdio.h>
#define SIZE 5
int arr[SIZE];

int f=-1;
int r=-1;


void displayQueue()
{
	//is queue empty??
	if(f==-1)
	{
		printf("Queue is empty\n");
	}
	else
	{
		int i=f;
		while(i<=r)
		{
			printf("%d,", arr[i]);
			i++;
		}
		printf("\n");
	}
}


void enqueue(int data)
{
	//is queue not full
	if(r!=SIZE-1)
	{
		//first element???
		if(f==-1)
		{
			f++;
		}
		r++;	
		arr[r] = data;
		displayQueue();
	}
	else
	{
		printf("Queue is full\n");
	}
}

int dequeue()
{

	if(f==-1)
	{
		printf("Queue is underflow\n");
		return -1;
	}
	else
	{
		int val = arr[f];
		if(f==r)
		{
			f=r=-1;
		}
		else
		{
			f++;
		}
		//displayQueue();
		return val;
	}
}



int main()
{
	enqueue(10);
	enqueue(20);
	enqueue(30);
	enqueue(40);
	enqueue(50);
	

	printf("dequeue element: %d\n", dequeue());
	displayQueue();
	printf("dequeue element: %d\n", dequeue());
	displayQueue();
	printf("dequeue element: %d\n", dequeue());
	displayQueue();
	printf("dequeue element: %d\n", dequeue());
	displayQueue();

	enqueue(50);
	
}


