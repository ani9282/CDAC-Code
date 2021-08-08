#include<stdio.h>
#include<stdlib.h>


typedef struct node
{
	int data;
	struct node *next;
}NODE;

NODE *head=NULL;


void insert(int a)
{
	NODE *tmp=(NODE*)malloc(sizeof(NODE));
	tmp->data=a;
	tmp->next=head;
	head=tmp;
}


void display()
{
	if(head==NULL)
		printf("\nList is Empty.....");
	else
	{
		NODE *tmp=head;
		printf("\n");
		while(tmp != NULL)
		{
			printf("%d -->",tmp->data);
			tmp=tmp->next;
		}
		printf("NULL\n");
	}
}

void append(int a)
{
	NODE *tmp=(NODE*)malloc(sizeof(NODE));
	tmp->data=a;
	tmp->next=NULL;
	
	if(head==NULL)
	{
		head=tmp;
	}
	else
	{
		NODE *it;
		it=head;
		while(it->next!= NULL)
		{
			it=it->next;
		}
		it->next=tmp;
	}
}

void deleteFirst()
{
	if(head!=NULL)
	{
		NODE *tmp;
		tmp=head;
		head=head->next;
		free(tmp);
	}
}

void deleteLast()
{
	if(head!=NULL)
	{
		if(head->next==NULL)
		{
			NODE *tmp;
			tmp=head;
			head=NULL;
			free(tmp);
		}
		else
		{		
			NODE *it=head;
			while(it->next->next!= NULL)
			{
				it=it->next;
			}
			NODE *tmp=it->next;
			it->next=NULL;
			free(tmp);
		}
	}
}

int getNodeCount()
{
	if(head==NULL)
		return 0;
	int count=1;
	NODE *it=head;
	while(it->next!=NULL)
	{
		count++;
		it=it->next;
	}
	return count;
}

void insertByPos(int a,int pos)
{
	int cnt=getNodeCount();
	if(pos==1)
		insert(a);
	else if(pos==cnt+1)
		append(a);
	else if(pos < 1 || pos > cnt+1)
		printf("\nInvalid Position Entered.......\n");
	else
	{
		NODE *tmp=(NODE*)malloc(sizeof(NODE));
		tmp->data=a;
		tmp->next=NULL;
		
		int x=1;
		NODE *it=head;
		while(x!=pos-1)
		{
			it=it->next;
			x++;
		}
		tmp->next=it->next;
		it->next=tmp;
	}	
}
	
	
void deleteByPos(int pos)
{
	int cnt=getNodeCount();
	if(pos==1)
		deleteFirst();
	else if(pos==cnt)
		deleteLast();
	else if(pos < 1 || pos > cnt)
		printf("\nInvalid Position Entered.......\n");
	else
	{
		int x=1;
		NODE *tmp=head;
		while(x!=pos-1)
		{
			tmp=tmp->next;
			x++;
		}
		NODE *tmp1=tmp->next;
		tmp->next=tmp1->next;
		free(tmp1);
	}
}


void reverse()
{
	NODE *it=head;
	NODE *itn=head;
	NODE *itp=NULL;
	
	while(it!=NULL)
	{
		itn=it->next;
		it->next=itp;
		itp=it;
		it=itn;
	}
	head=itp;
}


int main()
{
	/*insert(10);
	insert(20);
	insert(30);
	display();
	
	append(40);
	display();	
	
	deleteFirst();
	display();
	
	deleteLast();
	display();

	insertByPos(100,2);
	insertByPos(200,4);
	display();
	
	deleteByPos(2);
	display();
	
	reverse();
	display();*/
	
	int n,pos,ele,cnt;

	do
	{
		printf("\n1.Insert at 1st position\n2.Insert at last position\n3.Insert at your choice\n4.Delete 1st node\n5.Delete last Node\n6.Delete node from your choice\n7.Reverse a list\n8.Count of Nodes in Linked List\n9.Display\n10.Exit\nEnter your choice:");
		scanf("%d",&n);
		switch(n)
		{
			case 1:
				printf("\nEnter a data");
				scanf("%d",&ele);
				insert(ele);
				break;
			case 2:
				printf("\nEnter a data");
				scanf("%d",&ele);
				append(ele);
			case 3:
				printf("\nEnter position and data of Node you want to insert");
				scanf("%d%d",&pos,&ele);
				insertByPos(ele,pos);
				break;
			case 4:
				deleteFirst();
				break;
			case 5:
				deleteLast();
				break;
			case 6:
				printf("\nEnter position of Node you want to delete");
				scanf("%d",&pos);
				deleteByPos(pos);
				break;
			case 7:
				reverse();
				printf("\nLinked List Reversed");
				break;
			case 8:
				cnt=getNodeCount();
				printf("\nCount of Nodes=%d\n",cnt);
				break;
			case 9:
				display();
				break;
		}
	}
	while(n!=10);
	
	return 0;
}


