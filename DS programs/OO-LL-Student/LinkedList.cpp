#include "LinkedList.h"

ostream& operator<<(ostream& out, LinkedList& x)
{
	Node * it = x.head;
	while(it != NULL)
	{
		out<<*it<<endl;;
		it=it->Next();
	}	
	return out;
}

LinkedList::LinkedList() 
{
	head=NULL;
}

LinkedList::~LinkedList() 
{
	//LL empty?
	while(head != NULL)
	{
		Node * it = head;	
		head=head->Next();
		delete it;
	}	
}

LinkedList::LinkedList(LinkedList& x)
{
	//LinkedList l2=l1
	///this == l2
	/// x == l1	
	
	this->head=NULL;
	
	Node *it = x.head;
	while(it != NULL)
	{
		this->append(it->data);
		it=it->Next();
	}	
}


void LinkedList::operator=(LinkedList& x)
{
	//l2=l1
	///this == l2
	/// x == l1	
	this->deleteAll();
	this->head=NULL;
	
	Node *it = x.head;
	while(it != NULL)
	{
		this->append(it->data);
		it=it->Next();
	}	
}

void LinkedList::deleteAll() 
{
	//LL empty?
	while(head != NULL)
	{
		Node * it = head;	
		head=head->Next();
		delete it;
	}
	
	head=NULL;	
}

void LinkedList::insert(Student &x)
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

void LinkedList::deleteFirst()
{
	//check for empty LL...
	if(head != NULL)
	{
		Node *tmp = head;
		//Only one node?
		if(head->next == NULL)
			head = NULL;
		else
			head = tmp->next;
		
		delete tmp;		
	}
}

void LinkedList::deleteLast()
{
	//check for empty LL...
	if(head != NULL)
	{
		//Only one node?
		if(head->next == NULL)
		{
			Node *tmp = head;
			head = NULL;
			delete tmp;
		}			
		else
		{
			Node *it = head;
			while(it->next->next != NULL)
			{
				it=it->Next();
			}
			
			//we reached last but one node of linkedlist..			
			Node *tmp = it->next;
			it->next = NULL;
			delete tmp;
		}
	}
}

void LinkedList::append(Student &x)
{
	Node* tmp = new Node(x);	
	tmp->next = NULL;
	
	if(head==NULL)
	{
		head=tmp;
	}
	else
	{
		Node * it = head;
		while(it->next != NULL)
		{
			it=it->next;
		}
		it->next = tmp;
		tmp->next= NULL;
	}		
}

void LinkedList::RPrint() 
{
	_RPrint(head);
}

void LinkedList::_RPrint(Node *ptr) 
{
	if(ptr->next != NULL)
		_RPrint(ptr->next);
	
	cout<<*ptr<<"-->";
}

void LinkedList::reverse() 
{
	Node *it = head;
	Node *itn = head;
	Node *itp = NULL;
	while(it != NULL)
	{
		itn=it->next;
		it->next = itp;
		itp=it;
		it=itn;
	}
	head=itp;
}

int LinkedList::getIDByName(const char *name)
{
	Student tmp(name,0);
	
	Node *it = head;
	while(it != NULL)
	{
		if(it->data.isSameName(tmp))
		{
			return it->data.getID();
		}
		it = it->next;		
	}
	return -1;
}

const char* LinkedList::getNameByID(int id)
{
	Student tmp("UnKnown",id);
	
	Node *it = head;
	while(it != NULL)
	{
		if(it->data.isSameId(tmp))
		{
			return it->data.getName();
		}
		it = it->next;		
	}
	return "UnKnown";
}


