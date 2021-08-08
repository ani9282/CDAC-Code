
#ifndef __LinkedList_H__
#define __LinkedList_H__

#include <ostream>
#include <iostream>
using namespace std;

class LinkedList
{
	class Node
	{
		int data;
		Node *next;

	public:
		Node();
		Node(int);
		Node(int, Node*);
		~Node();
		Node(Node &);
		void operator=(Node &);
		void operator++(int x);	
		Node* getNext();
		void setNext(Node*);
		int getData();
		void setData(int);
	};

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


