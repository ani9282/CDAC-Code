						
#ifndef __CLinkedList_H__
#define __CLinkedList_H__

#include "Node.h"
#include <ostream>
#include <iostream>
using namespace std;

class CLinkedList
{
	Node * head;
	void deleteAllNodes();	
public:
	CLinkedList();
	CLinkedList(int startValue);
	~CLinkedList();
	//CLinkedList(const CLinkedList &);
	//void operator=(const CLinkedList &);
	void insert(int data);
	void append(int data);
	void deleteFirst();
	void deleteLast();	
	friend ostream& operator<<(ostream&, CLinkedList&);
};

#endif


