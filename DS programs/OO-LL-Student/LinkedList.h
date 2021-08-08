

#ifndef __LL_H__
#define __LL_H__

#include <iostream>
#include "Node.h"

using namespace std;

class LinkedList
{
	Node* head;
	void deleteAll(); 
	void _RPrint(Node *ptr); 

public:
	LinkedList();
	~LinkedList();
	LinkedList(LinkedList&);
	void operator=(LinkedList&);
	void insert(Student &x);
	void append(Student &x);
	friend ostream& operator<<(ostream& out, LinkedList& x);
	void RPrint(); 
	void deleteFirst();
	void deleteLast();
	void reverse();
	
	int getIDByName(const char *name);
	const char* getNameByID(int id);
};

#endif


