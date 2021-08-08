#include"Node.h"
Node::Node()
{
data=0;
next=NULL;
}


Node::Node(int x,Node* ptr)
{
data=x;
next=ptr;
}

Node::~Node()
{
cout<<"Node:~Node"<<endl;
next=NULL;
}


void Node::setData(int d)
{
data=d;
}

void Node::setNext(Node* ptr)
{
next=ptr;
}

Node* Node::getNext()
{
return next;
}

int Node::getData()
{
return data;
}
