

#include <stdio.h>
#include <stdlib.h>

int size=0;
int *arr=0;

int f=-1;
int r=-1;

int isFull()
{
	if(r==size-1)
		return 1;
	else
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
	if(!isFull())
	{
		//first element???
		if(f==-1)
		{
			f++;
		}
		r++;	
		arr[r] = data;
		//displayQueue();
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
			f++;
		}
		//displayQueue();
		return val;
	}
}


int main()
{

	init();

int i=0;
	while(++i != 8)
	{
		enqueue(10);
		enqueue(20);
		enqueue(30);
		enqueue(40);
		enqueue(50);
	}

	printf("dequeue element: %d\n", dequeue());
	displayQueue();
	printf("dequeue element: %d\n", dequeue());
	displayQueue();
	printf("dequeue element: %d\n", dequeue());
	displayQueue();
	printf("dequeue element: %d\n", dequeue());
	displayQueue();

	enqueue(50);
	
	fini();
}


