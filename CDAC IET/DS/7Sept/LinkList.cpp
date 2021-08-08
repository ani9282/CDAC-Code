#include"LinkList.h"


ostream& operator<<(ostream& out,LinkList &x)
{
Node* it=x.head;
 

	while(it!=NULL)
	{
	out<<*it<<endl;
	it=it->getNext();
	
        }
        return out;	
        
}

LinkList::LinkList()
{
head=NULL;
}

LinkList::~LinkList()
{

while(head!=NULL)
{
	Node* it=head;
	it=head;
	head=head->getNext();
	delete it;
}

}


void LinkList::insert(Student &x)
{
	Node* tmp = new Node(x);	
	tmp->next=NULL;
	
	//first node????
	if(head==NULL)
	{
		head=tmp;			
	}
	else
	{
		tmp->next=head;
		head=tmp;	
	}
}

int LinkList::getIdbyname(const char *name)
{
	Student tmp(name,0);//here student is data type and not class name
	
	Node* it=head;
	LinkList l1
	while(it!=NULL)
	{
		if(it->data.issamename(tmp))
		{
		 return it->data.getId();
		}
		it=it->next;
	}
	return -1;	
}

char* LinkList::getNameByID(int id)
{
Student tmp("NULL",id);
Node* it=head;

	while(it!=NULL)
	{
		if(it->data.issameid(tmp))
		{
		return it->data.getName();
		}
	
	it=it->next;
	}
	return "NULL";
}

