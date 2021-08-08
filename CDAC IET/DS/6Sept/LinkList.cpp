
#include"LinkList.h"

LinkList::LinkList()
{
head=NULL;
}

LinkList::~LinkList()
{

}

void LinkList::insert(int data)
{
Node *tmp = new Node();//(data, head);
tmp->setData(data);
tmp->setNext(head);
	head=tmp;
}

ostream& operator<<(ostream& out,LinkList &x)
{
if(x.head==NULL)
{
cout<<"linklist empty"<<endl;
return out;
}

Node* it=x.head;
while(it!= NULL)
	{
		out<<it->getData()<<"->";
		it=it->getNext();
//		(*it)++;
		//it.operator++(int /*just a placeholder*/)
	}
	return out;
}



void LinkList::append(int data)
{
	Node* temp=new Node(data,NULL);
	if(head==NULL)
	{
		head=temp;
		return;
	}
	Node* it=head;
	while(it->getNext()!=NULL)
	{
	it=it->getNext();
	//it->setNext(temp);
	}
	it->setNext(temp);
}

void LinkList::delete_first()
{
	if(head==NULL)
	{
	cout<<"linklist empty"<<endl;
	}
	Node* temp;
	temp=head;
	head=head->getNext();
	delete temp;
	
}



LinkList::LinkList(LinkList &r)
{
this->head=NULL;
Node* it=r.head;
while(it!=NULL)
{
this->append(it->getData());
it=it->getNext();
}

}
