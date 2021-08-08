#include"Node.h"
#include"Student.h"
Node::Node(Student &x)
{
data=x;
next=NULL;

}

Node::~Node()
{

next=NULL;

}

ostream& operator<<(ostream& out,Node &x)
{
out<<x.data;

}
