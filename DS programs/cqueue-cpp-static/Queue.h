

#ifndef __QUEUE_H__
#define __QUEUE_H__

#include<iostream>
#include<ostream>

using namespace std;

#define SIZE 10


class Queue
{
	int arr[SIZE];
	int f;
	int r;

public:
	
	Queue()
	{
		f=r=-1;
		int i=0;
		while(i<SIZE)
		{
			arr[i]=0;
			i++;
		}
	}

	~Queue()
	{
		f=r=-1;
	}


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


	friend ostream& operator<<(ostream& out, Queue& q);

	void enqueue(int data)
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

			arr[r] = data;
			cout<<*this;
		}
		else
		{
			cout<<"Queue is full"<<endl;
		}
	}


	int dequeue()
	{

		if(isEmpty())
		{
			cout<<"Queue is underflow"<<endl;
			return -1;
		}
		else
		{
			int val = arr[f];
			arr[f]=0;
			if(f==r)
			{
				f=r=-1;
			}
			else
			{
				if(f==SIZE-1)
					f=0;
				else
					f++;
			}

			return val;
		}
	}

	void operator<<(int x)
	{
		//q1<<58;
		//q1.operator<<(int)
		enqueue(x);
	}

	Queue operator+(const Queue &x)
	{
		//q1+q2
		//q1 >>> this
		//q2 >>> x

		Queue tmp;
		
		
		int i=0;
		while(i<SIZE)
		{
			tmp.arr[i] = this->arr[i] + x.arr[i];
			i++;
		}

		tmp.f = 0;
		tmp.r = SIZE-1;
		return tmp;

	}

	
};

ostream& operator<<(ostream& out, Queue& q)
{

	if(q.isEmpty())
	{
		out<<"Queue is empty"<<endl;
	}
	else
	{
		int i=q.f;
		while(i!=q.r)
		{
			out<<q.arr[i]<<",";
			if(i==SIZE-1)
				i=0;
			else
				i++;
		}
		out<<q.arr[i];
		out<<endl;
	}
	return out;	
}



#endif

