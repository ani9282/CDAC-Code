

#include <stdio.h>
#include <stdlib.h>

int size=0;
int *arr=0;

int f=-1;
int r=-1;

int isFull()
{
	if(f==0 && r==size-1)
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


void insertFromF(int data)
{
	if(!isFull())
	{
		//first element???
		if(f==-1)
		{
			f++;
			r++;
			arr[r]=data;
			return;			
		}		
		else if(f!=0)    //empty space before F)]
		{
			f--;
			arr[f]=data;
			return;
		}             
		else if(r+1 <= size-1)	//empty space after R)
		{
			int i=r;
			r++;
			while(i>=f)
			{
				arr[i+1]=arr[i];
				i--;
			}
			arr[f]=data;
			return;
		}
		else
		{
			printf("something went wrong... gadbad...\n");
		}
		
		
	}
	else
	{
		printf("Queue is full\n");
	}
}
               

void insertFromR(int data)
{
	if(!isFull())
	{
		//first element???
		if(f==-1)
		{
			f++;
			r++;
			arr[r]=data;
			return;			
		}		
		else if(r+1 <= size-1)    //empty space after R)]
		{
			r++;
			arr[r]=data;
			return;
		}
		else if(f!=0)		//empty space before F)
		{
			int i=f;
			f--;
			while(i<=r)
			{
				arr[i-1]=arr[i];
				i++;2
			}
			arr[r]=data;
			return;
		}
		else
		{
			printf("something went wrong... gadbad...\n");
		}
		
		
	}
	else
	{
		printf("Queue is full\n");
	}
}

int removeFromF()
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
		//return val;
	}
}

int removeFromR()
{

	if(isEmpty())
	{
		printf("Queue is underflow\n");
		return -1;
	}
	else
	{
		int val = arr[r];
		if(f==r)
		{
			f=r=-1;
		}
		else
		{
			r--;
		}
		//displayQueue();
		//return val;
	}
}


int main()
{

	init();

//	int i=0;
//	while(++i != 8)
	{
		insertFromR(10);
		insertFromF(20);
		insertFromR(30);
		insertFromF(40);
		insertFromR(50);
		removeFromF();
		insertFromR(80);
		displayQueue();

	}

	
	fini();
}


