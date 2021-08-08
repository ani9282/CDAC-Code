
#ifndef __LinkedList_H__
#define __LinkedList_H__

#include "Node.h"
#include <ostream>
#include <iostream>
using namespace std;

class LinkedList
{
	Node * head;
	void deleteAllNodes();

public:
	LinkedList();
	LinkedList(int startValue);
	~LinkedList();
	LinkedList(const LinkedList &);
	void operator=(const LinkedList &);
	void insert(int data);
	void append(int data);
	void deleteFirst();
	void deleteLast();
	friend ostream& operator<<(ostream&, LinkedList&);
};

#endif


