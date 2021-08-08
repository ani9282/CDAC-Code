#include"LinkList.h"
LinkList::LinkList()
{
head=NULL;
}
LinkList::~LinkList()
{
cout<<"LinkList::~LinkList"<<endl;
}


LinkList::LinkList(int data)
{
	Node* tmp = new Node(data,head);
	head=tmp;
	//tmp->setNext(head);
	tmp->setNext(head);
}


void LinkList::insert(int data)
{
        Node* temp=new Node(data,head);
	if(head==NULL)
	{
	head=temp;
	temp->setNext(head);
		return;
	}
	
	Node* it=head;
	while(it->next!=head)
	{
	it=it->getNext();
	}
	  it->setNext(temp);
	  head=temp;
}

ostream& operator<<(ostream& out,LinkList &x)
{
if(x.head==NULL)
{
	cout<<"ithe kahi nahi"<<endl;
}
else
	{
		Node* it=x.head;
		
		do
		{
			
			out<<it->getData()<<"->";
			it=it->getNext();
		}
		while(it!=x.head);
		return out;
		
	}
}

void  LinkList::append(int data)
{
 Node* temp=new Node(data,head);
	if(head==NULL)
	{
	head=temp;
	temp->setNext(head);
		return;
	}
	
	Node* it=head;
	while(it->next!=head)
	{
	it=it->getNext();
	}
	  it->setNext(temp);
	  temp->setNext(head);
	
}

void LinkList::delete_first()
{

	if(head != NULL)
	{
		if(head == head->getNext())
		{
			Node *tmp=head;
			head=NULL;
			delete tmp;		
		}
		else
		{
		
		//Swap...
			int t=head->getData();
		head->setData(head->getNext()->getData());			
			head->getNext()->setData(t);

			Node *tmp=head->getNext();
			head->setNext(tmp->getNext());
			delete tmp;
		}
          }
}
