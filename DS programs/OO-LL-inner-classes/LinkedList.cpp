#include <iostream>
#include "LinkedList.h"
using namespace std;


LinkedList::LinkedList()
{
	head=NULL;
}

LinkedList::LinkedList(int startValue)
{
	LinkedList::Node *tmp = new LinkedList::Node(startValue);
	head=tmp;
}

LinkedList::~LinkedList()
{
	cout<<"LinkedList::~LinkedList"<<endl;
	deleteAllNodes();
}

LinkedList::LinkedList(const LinkedList &x)
{
	//LinkedList l2=l1
	//this >> l2
	//x >> l1
	this->head=NULL;
	LinkedList::Node *it = x.head;
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
	LinkedList::Node *it = x.head;
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
		LinkedList::Node *it = head;
		head = it->getNext();
		delete it;
	}
}

void LinkedList::insert(int data)
{
	LinkedList::Node *tmp = new LinkedList::Node(data, head);
	head=tmp;
}

void LinkedList::append(int data)
{
	LinkedList::Node *tmp = new LinkedList::Node(data, NULL);

	//first Node???
	if(head == NULL)
	{
		head=tmp;
		return;
	}

	//go to last node...
	LinkedList::Node *it=head;
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
		LinkedList::Node *tmp=head;
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
			LinkedList::Node *tmp=head;
			head=NULL;
			delete tmp;
		}
		// ohhhhhhhh we have more than 1 node
		else
		{
			//go to last but one node...
			LinkedList::Node *it=head;
			while(it->getNext()->getNext() != NULL)
			{
				it=it->getNext();
			}
			LinkedList::Node *tmp =it->getNext();
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
	LinkedList::Node *it=x.head;
	while(it!= NULL)
	{
		out<<it->getData()<<"-->";
		it=it->getNext();
//		(*it)++;
		//it.operator++(int /*just a placeholder*/)

	}
	return out;
}

LinkedList::Node::Node()
{
	data=0;
	next=NULL;
}

LinkedList::Node::Node(int d)
{
	this->data=d;
	this->next=NULL;
}

LinkedList::Node::Node(int d, LinkedList::Node* ptr)
{
	this->data=d;
	this->next=ptr;
}

LinkedList::Node::~Node()
{
	next=NULL;	
}

LinkedList::Node::Node(LinkedList::Node &x)
{	
	this->data=x.data;
	this->next=NULL;
}

void LinkedList::Node::operator=(LinkedList::Node &x)
{
	this->data=x.data;
	this->next=NULL;
}

void LinkedList::Node::operator++(int x)
{
	cout<<"here...."<<endl;
	
}

LinkedList::Node* LinkedList::Node::getNext()
{
	return next;
}

void LinkedList::Node::setNext(LinkedList::Node* ptr)
{
	next=ptr;	
}

int LinkedList::Node::getData()
{
	return data;
}

void LinkedList::Node::setData(int x)
{
	data=x;
}




