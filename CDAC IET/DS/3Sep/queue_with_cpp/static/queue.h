#include<iostream>
using namespace std;

#ifndef _QUEUE__H_
#define _QUEUE__H_
#define SIZE 5

class queue
{
	
	int arr[SIZE];
	int f=-1;
	int r=-1;

public:
	void enqueue(int n);
	int dequeue();
	void display();


};

#endif
