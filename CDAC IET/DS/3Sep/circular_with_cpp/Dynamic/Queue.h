#include<iostream>
using namespace std;

#ifndef _QUEUE__H_
#define _QUEUE__H_

class queue
{
	int SIZE;
	int *arr;
	int f=-1;
	int r=-1;

public:
	queue(int x);
	~queue();
	void enqueue(int n);
	int dequeue();
	void display();
	int isFull();
	int isEmpty();

};

#endif
