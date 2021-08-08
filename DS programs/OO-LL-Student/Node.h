
#ifndef __NODE_H__
#define __NODE_H__

#include <iostream>
#include <ostream>
#include "Student.h"

using namespace std;

class Node
{
	Student data;
	Node* next;
	
public:

	Node(Student &x);	
	~Node();		
	friend ostream& operator<<(ostream& out, Node& x);	
	friend class LinkedList;
	
};

#endif

