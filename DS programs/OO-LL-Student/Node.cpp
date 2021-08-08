
#include "Node.h"

ostream& operator<<(ostream& out, Node& x)
{
	out<<x.data;
	return out;
}

Node::Node(Student &x) : data(x)
{	
	data=x;
	next=NULL;
}

Node::~Node()
{
	next=NULL;
}


