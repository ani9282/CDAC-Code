#include <iostream>

#include "Node.h"
using namespace std;

Node::Node()
{
	data=0;
	next=NULL;
}

Node::Node(int d)
{
	this->data=d;
	this->next=NULL;
}

Node::Node(int d, Node* ptr)
{
	this->data=d;
	this->next=ptr;
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


