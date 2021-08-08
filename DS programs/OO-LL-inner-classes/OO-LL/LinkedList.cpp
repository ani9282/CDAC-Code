#include <iostream>
#include "LinkedList.h"
using namespace std;

LinkedList::LinkedList()
{
	head=NULL;
}

LinkedList::LinkedList(int startValue)
{
	Node *tmp = new Node(startValue);
	head=tmp;
}

LinkedList::~LinkedList()
{
	cout<<"LinkedList::~LinkedList"<<endl;
	deleteAllNodes();ll.cpp ll.h node.h node.cpp

}

LinkedList::LinkedList(const LinkedList &x)
{
	//LinkedList l2=l1
	//this >> l2
	//x >> l1
	this->head=NULL;
	Node *it = x.head;
	while(it != NULL)	
	{
		this->append(it->getData());
		it=it->getNext();
//		it++;
	}
}


void LinkedList::operator=(const LinkedList &x)
{
	//l2=l1
	//this >> l2
	//x >> l1
	this->deleteAllNodes();
	Node *it = x.head;
	while(it != NULL)	
	{
		this->append(it->getData());
		it=it->getNext();
//		it++;
	}
}

void LinkedList::deleteAllNodes()
{
	while(head != NULL)
	{
		Node *it = head;
		head = it->getNext();
		delete it;
	}
}

void LinkedList::insert(int data)
{
	Node *tmp = new Node(data, head);
	head=tmp;
}

void LinkedList::append(int data)
{
	Node *tmp = new Node(data, NULL);

	//first Node???
	if(head == NULL)
	{
		head=tmp;
		return;
	}

	//go to last node...
	Node *it=head;
	while(it->getNext() != NULL)
	{
		it=it->getNext();
	}

	it->setNext(tmp);
}

void LinkedList::deleteFirst()
{
	//do we have something to delete??
	if(head != NULL)
	{
		Node *tmp=head;
		head=tmp->getNext();
		delete tmp;
	}
}

void LinkedList::deleteLast()
{
	//do we have something to delete??
	if(head != NULL)
	{
		//only one node in LL??
		if(head->getNext() == NULL)
		{
			Node *tmp=head;
			head=NULL;
			delete tmp;
		}
		// ohhhhhhhh we have more than 1 node
		else
		{
			//go to last but one node...
			Node *it=head;
			while(it->getNext()->getNext() != NULL)
			{
				it=it->getNext();
			}
			Node *tmp =it->getNext();
			it->setNext(NULL);
			delete tmp;
		}
	}
}

ostream& operator<<(ostream& out, LinkedList& x)
{
	//empty???
	if(x.head == NULL)
	{
		out<<"LL is empty...\n"<<endl;
		return out;
	}

	//go to last node...
	Node *it=x.head;
	while(it!= NULL)
	{
		out<<it->getData()<<"-->";
		it=it->getNext();
//		(*it)++;
		//it.operator++(int /*just a placeholder*/)

	}
	return out;
}


