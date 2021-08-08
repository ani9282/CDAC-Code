#include <iostream>
#include "CLinkedList.h"
using namespace std;

CLinkedList::CLinkedList()
{
	head=NULL;
}

CLinkedList::CLinkedList(int startValue)
{
	Node *tmp = new Node(startValue);
	head=tmp;
	tmp->setNext(head);
}

CLinkedList::~CLinkedList()
{
	cout<<"CLinkedList::~CLinkedList"<<endl;
	deleteAllNodes();
}

CLinkedList::CLinkedList(const CLinkedList &x)
{
/*
	//CLinkedList l2=l1
	//this >> l2
	//x >> l1
	this->head=NULL;
	Node *it = x.head;
	do
	{
		this->append(it->getData());
		it=it->getNext();
	}
	while(it != x.head);
*/  
}

void CLinkedList::operator=(const CLinkedList &x)
{
/*	//l2=l1
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
*/
}

void CLinkedList::deleteAllNodes()
{
	//go to last node...
	while(head != NULL)
	{
		deleteLast();
	}

}

void CLinkedList::insert(int data)
{
	Node *tmp = new Node(data, head);

	if(head == NULL)
	{
		head=tmp;
		tmp->setNext(head);
		return;
	}

	Node *it=head;
	while(it->getNext() != head)	
	{
		it=it->getNext();
	}

	it->setNext(tmp);
	head=tmp;
}

void CLinkedList::append(int data)
{
	Node *tmp = new Node(data, head);

	if(head == NULL)
	{
		head=tmp;
		tmp->setNext(head);
		return;
	}

	Node *it=head;
	while(it->getNext() != head)	
	{
		it=it->getNext();
	}

	it->setNext(tmp);
	tmp->setNext(head);
}

void CLinkedList::deleteFirst()
{
	//do we have something to delete??
	if(head != NULL)
	{
		if(head == head->getNext())
		{
			Node *tmp=head;
			head=NULL;
			delete tmp;		
		}
		else
		{
			//Swap...
			int t=head->getData();
		head->setData(head->getNext()->getData());			
			head->getNext()->setData(t);

			Node *tmp=head->getNext();
			head->setNext(tmp->getNext());
			delete tmp;
		}
	}
}

void CLinkedList::deleteLast()
{
	//do we have something to delete??
	if(head != NULL)
	{
		//Only one node
		if(head == head->getNext())
		{
			Node *tmp=head;
			head=NULL;
			delete tmp;		
		}
		else
		{
			//Swap...
			Node *it=head;
			while(it->getNext()->getNext() != head)
				it=it->getNext();
						
			Node *tmp=it->getNext();

			it->setNext(head);
			delete tmp;
		}
	}
}

ostream& operator<<(ostream& out, CLinkedList& x)
{
	//empty???
	if(x.head == NULL)
	{
		out<<"CLL is empty...\n"<<endl;
		return out;
	}

	//go to last node...
	Node *it=x.head;
	do
	{
		out<<it->getData()<<"-->";
		it=it->getNext();
	}
	while(it != x.head);
	return out;
}


