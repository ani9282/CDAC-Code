

#include <stdio.h>
#include <stdlib.h>

int size=0;
int *arr=0;

int f=-1;
int r=-1;

int isFull()
{
	if( (f==r+1) || (f==0 && r==size-1) )
		return 1;
	
	return 0;
}

int isEmpty()
{
	if(f==-1)
		return 1;
	else
		return 0;
}


void init()
{
	printf("Enter queue size: ");
	scanf("%d", &size);

	arr = (int*) malloc(size * sizeof(int));
}

void fini()
{
	free(arr);
}

void displayQueue()
{
	if(isEmpty())
	{
		printf("Queue is empty\n");
	}
	else
	{
		int i=f;
		while(i!=r)
		{
			printf("%d,", arr[i]);
			if(i==size-1)
				i=0;
			else
				i++;
		}
		printf("%d,", arr[i]);
		printf("\n");
	}
}


void enqueue(int data)
{
	if(!isFull())
	{
		//first element???
		if(f==-1)
		{
			f=0;
		}

		if(r==size-1)
			r=0;
		else
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

	if(isEmpty())
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
			if(f==size-1)
				f=0;
			else
				f++;
		}
		displayQueue();
		return val;
	}
}

















int main()
{


	

	init();

int i=0;
	while(++i != 1000)
	{
		enqueue(10);
		enqueue(20);
		enqueue(30);
		enqueue(40);
		enqueue(50);

		dequeue();
		enqueue(50);

		enqueue(800);

	}

	/*printf("dequeue element: %d\n", dequeue());
	displayQueue();
	printf("dequeue element: %d\n", dequeue());
	displayQueue();
	printf("dequeue element: %d\n", dequeue());
	displayQueue();
	printf("dequeue element: %d\n", dequeue());
	displayQueue();*/
	displayQueue();
	fini();
}


