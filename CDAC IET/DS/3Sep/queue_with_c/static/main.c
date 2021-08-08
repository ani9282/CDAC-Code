#include<stdio.h>

#define SIZE 5

int arr[SIZE];
int f=-1;
int r=-1;


void enqueue(int n)
{
	if(r!=SIZE-1)
	{
		
		if(f==-1)
		{
			f++;
			r++;
		}
		else
		{	
			r++;
		}
		arr[r]=n;
	}
	else
	{
		printf("\nQueue is Full");
	}
}


int dequeue()
{
	int n;
	if(f==-1)
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
		for(int i=f;i<=r;i++)
		{
			printf("%d <--",arr[i]);
		}
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
		case 4:			
			break;
			
		}
	}
	while(n!=4);
}
