
#ifndef __DLinkedList_H__
#define __DLinkedList_H__

#include "Node.h"
#include <ostream>
#include <iostream>
using namespace std;

class DLinkedList
{
	Node * head;
	Node * tail;
	void deleteAllNodes();
	void reversePrint(Node *);
public:
	DLinkedList();
	DLinkedList(int startValue);
	~DLinkedList();
	DLinkedList(const DLinkedList &);
	void operator=(const DLinkedList &);
	void insert(int data);
	int operator[](int x);
	void append(int data);
	void deleteFirst();
	void deleteLast();
	void reversePrint();
	friend ostream& operator<<(ostream&, DLinkedList&);
};

#endif


