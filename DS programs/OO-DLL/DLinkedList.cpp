
#include <iostream>
#include "DLinkedList.h"
using namespace std;

DLinkedList::DLinkedList()
{
	head=NULL;
	tail=NULL;
}

DLinkedList::DLinkedList(int startValue)
{
	Node *tmp = new Node(NULL, startValue, NULL);
	head=tmp;
	tail=tmp;
}

DLinkedList::~DLinkedList()
{
	cout<<"DLinkedList::~DLinkedList"<<endl;
	deleteAllNodes();
}

DLinkedList::DLinkedList(const DLinkedList &x)
{
/*
	//DLinkedList l2=l1
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
*/
}


void DLinkedList::operator=(const DLinkedList &x)
{
/*
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
*/
}

void DLinkedList::deleteAllNodes()
{
	while(head != NULL)
	{
		Node *it = head;
		head = it->getNext();
		delete it;
	}
}

void DLinkedList::insert(int data)
{
	Node *tmp = new Node(NULL, data, NULL);
	if(head==NULL)
	{
		head=tail=tmp;
		return;
	}
	tmp->setNext(head);
	head->setPrev(tmp);
	head=tmp;

}

void DLinkedList::append(int data)
{
	Node *tmp = new Node(NULL, data, NULL);
	if(head==NULL)
	{
		head=tail=tmp;
		return;
	}
	tmp->setPrev(tail);
	tail->setNext(tmp);
	tail=tmp;
}

void DLinkedList::deleteFirst()
{
	//do we have something to delete??
	if(head != NULL)
	{
		if(head==tail)
		{	
			Node* tmp=head;
			head=tail=NULL;
			delete tmp;
		}
		else
		{	
			Node* tmp=head;
			head=head->getNext();

			head->setPrev(NULL);
			delete tmp;
										
		}	
				
	}
		
}

void DLinkedList::deleteLast()
{
	//NO Nodes...
	if(head != NULL)
	{
		//single node
		if(head==tail)
		{	
			Node* tmp=head;
			head=tail=NULL;
			delete tmp;
		}
		else
		{	
			Node* tmp=tail;
			tail=tail->getPrev();

			tail->setNext(NULL);
			tmp->setPrev(NULL);
			delete tmp;
										
		}	
				
	}
}

/*void DLinkedList::reversePrint()
{
	//this->head
	reversePrint(this->head);
	cout<<endl;
}

void DLinkedList::reversePrint(Node* ptr)
{
	if(ptr->getNext() != NULL)
	{
		reversePrint(ptr->getNext());
	}
	cout<<ptr->getData()<<"-->";
}*/

ostream& operator<<(ostream& out, DLinkedList& x)
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
	}
	return out;
}



int DLinkedList::operator[](int x)
{
	

}



