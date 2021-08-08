
#include"queue.h"


void queue::enqueue(int n)
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
		cout<<"\nQueue is Full";
	}
}


int queue::dequeue()
{
	int n;
	if(f==-1)
	{
		cout<<"\nQueue is empty";
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


void queue::display()
{
	if(f==-1)
		cout<<"\nQueue is empty";
	else
	{
		for(int i=f;i<=r;i++)
		{
			cout<<" <--"<<arr[i];
		}
		cout<<"\n";
	}
}

