#include<stdio.h>

#define SIZE 5

int arr[SIZE];
int f=-1;
int r=-1;

int isFull()
{
	if( (f==r+1) || (f==0 && r==SIZE-1) )
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


void enqueue(int n)
{
	if(!isFull())
	{
		//first element???
		if(f==-1)
		{
			f=0;
		}

		if(r==SIZE-1)
			r=0;
		else
			r++;

		arr[r] = n;
		//displayQueue();
	}
	else
	{
		printf("Queue is full\n");
	}
}


int dequeue()
{
	int n;
	
	if(isEmpty())
	{
		printf("\nQueue is empty");
	}
	else if(r==f)
	{
		n=arr[f];
		r=f=-1;
		
	}
	else
	{
		n=arr[f];
		if(f==SIZE-1)
			f=0;
		else
			f++;
	}

return n;

}


void display()
{
	if(f==-1)
		printf("\nQueue is empty");
	else
	{
		int i=f;
		for(;i!=r;)
		{
			printf("%d <--", arr[i]);
			if(i==SIZE-1)
				i=0;
			else
				i++;
		}
		printf("%d <--", arr[i]);
		printf("\n");
	}	
}

int main()
{

	int n,no;
	do{
		printf("\n1.Insert No:\n2.Delete No:\n3.Display Queue :\n4.Exit\nEnter what you want to do:");
		scanf("%d",&n);
		switch(n)
		{
		case 1:
		
			printf("\nEnter a number:");
			scanf("%d",&no);
			enqueue(no);
			break;
	
		case 2:
			printf("\nDequeue:%d\n",dequeue());
			break;

		case 3:
			display();
			break;
			
		}
	}
	while(n!=4);
}
