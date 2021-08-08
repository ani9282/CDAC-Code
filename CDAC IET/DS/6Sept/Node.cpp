#include"Node.h"

Node::Node()
{
data=0;
next=NULL;
}

Node::Node(int x, Node* ptr)
{
this->data=x;
this->next=ptr;
}

Node::~Node()
{
next=NULL;
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
