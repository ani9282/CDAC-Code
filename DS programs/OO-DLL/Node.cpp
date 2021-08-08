#include <iostream>
#include "Node.h"
using namespace std;

Node::Node()
{
	prev=NULL;
	data=0;
	next=NULL;
}

Node::Node(int d)
{
	this->prev=NULL;
	this->data=d;
	this->next=NULL;
	
}

Node::Node(int d, Node* nextPtr)
{
	this->data=d;
	this->next=nextPtr;
	this->prev=NULL;
}

Node::Node(Node* prevPtr, int d)
{
	this->data=d;
	this->next=NULL;
	this->prev=prevPtr;
}

Node::Node(Node* prevPtr, int d, Node* nextPtr)
{
	this->data=d;
	this->next=nextPtr;
	this->prev=prevPtr;
}


Node::~Node()
{
	next=NULL;	
}

Node::Node(Node &x)
{	
	this->data=x.data;
	this->next=NULL;
}

void Node::operator=(Node &x)
{
	this->data=x.data;
	this->next=NULL;
}

void Node::operator++(int x)
{
	cout<<"here...."<<endl;
	
}

Node* Node::getPrev()
{
	return prev;
}

void Node::setPrev(Node* ptr)
{
	prev=ptr;
}

Node* Node::getNext()
{
	return next;
}

void Node::setNext(Node* ptr)
{
	next=ptr;	
}

int Node::getData()
{
	return data;
}

void Node::setData(int x)
{
	data=x;
}


