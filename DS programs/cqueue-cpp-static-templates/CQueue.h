

#ifndef __CQueue_H__
#define __CQueue_H__

#include<iostream>
#include<ostream>

using namespace std;

#define SIZE 10

template <class T>

class CQueue
{
	T arr[SIZE];
	int f;
	int r;

public:
	
	CQueue()
	{
		f=r=-1;
		int i=0;
		while(i<SIZE)
		{
			arr[i]=0;
			i++;
		}
	}

	~CQueue()
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

	void enqueue(T data)
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
		}
		else
		{
			cout<<"CQueue is full"<<endl;
		}
	}

	T dequeue()
	{

		if(isEmpty())
		{
			cout<<"CQueue is underflow"<<endl;
			return -1;
		}
		else
		{
			T val = arr[f];
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

	void operator<<(T x)
	{
		//q1<<58;
		//q1.operator<<(int)
		enqueue(x);
	}

	CQueue operator+(const CQueue<T> &x)
	{
		//q1+q2
		//q1 >>> this
		//q2 >>> x

		CQueue<T> tmp;
		
		
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
	
	void displayQueue()
	{
		if(isEmpty())
		{
			cout<<"CQueue is empty"<<endl;
		}
		else
		{
			int i=f;
			while(i!=r)
			{
				cout<<arr[i]<<",";
				if(i==SIZE-1)
					i=0;
				else
					i++;
			}
			cout<<arr[i];
			cout<<endl;
		}
	}
};


#endif

