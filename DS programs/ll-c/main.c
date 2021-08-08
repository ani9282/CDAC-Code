
#include <stdio.h>
#include <stdlib.h>

struct node
{
	int data;
	struct node *next;	
};

typedef struct node Node;


Node * head=NULL;


void insert(int data)
{
	Node *tmp = (Node*) malloc (sizeof(Node));
	tmp->data = data;
	tmp->next = NULL;
	head=tmp;
}

void append(int data)
{
	Node *tmp = (Node*) malloc (sizeof(Node));
	tmp->data = data;
	tmp->next = NULL;

	//first Node???
	if(head == NULL)
	{
		head=tmp;
		return;
	}

	//go to last node...
	Node *it=head;
	while(it->next != NULL)
	{
		it=it->next;
	}

	it->next=tmp;				
}


int deleteLast()
{
	//do we have something to delete??
	if(head != NULL)
	{
		//only one node in LL??
		if(head->next == NULL)
		{
			Node *tmp=head;
			head=NULL;

			free(tmp);
		}
		// ohhhhhhhh we have more than 1 node
		else
		{
			//go to last but one node...
			Node *it=head;
			while(it->next->next != NULL)
			{
				it=it->next;
			}
			Node *tmp =it->next;
			it->next=NULL;
			free(tmp);
		}
	}
}


int deleteFirst()
{
	//do we have something to delete??
	if(head != NULL)
	{
		Node *tmp=head;
		head=tmp->next;
		free(tmp);		
	}
}


int getNumberOfNodes()
{
	//empty???
	if(head == NULL)
	{
		return 0;
	}

	//go to last node...
	int count=0;
	Node *it=head;
	while(it!= NULL)
	{
		count++;
		it=it->next;
	}
	return count;

}


void insertByPos(int data, const int pos)
{
	//Validate pos...
	int noOfNodes=getNumberOfNodes();

	if(pos == 1)
		insert(data);	
	else if(pos == noOfNodes+1)
		append(data);
	else if(pos<1 || pos > noOfNodes+1)
		printf("Invalid Pos... \n");
	else
	{
		Node *tmp = (Node*) malloc (sizeof(Node));
		tmp->data = data;
		tmp->next = NULL;

		//go to pos-1 node...
		Node *it=head;
		int x=1;
		while(x!=pos-1)
		{
			it=it->next;
			x++;
		}

		tmp->next = it->next;
		it->next = tmp;
		
	}
	
}



void display()
{

	//empty???
	if(head == NULL)
	{
		printf("LL is empty...\n");
		return;
	}

	//go to last node...
	Node *it=head;
	while(it!= NULL)
	{
		printf("%d-->", it->data);
		it=it->next;
	}
	printf("\n");

}

void reverse()
{
	Node *itn=head;
	Node *it=head;
	Node *itp=NULL;	

	while(it != NULL)
	{
		itn = it->next;
		it->next = itp;
		itp = it;
		it = itn;
	}
	head = itp;	
}

int main()
{
	int i=0;

	for(i=0;i<0;i++)
		append(i);

	display();
	printf("Count:%d\n", getNumberOfNodes());
	
	reverse();
	display();
	printf("Count:%d\n", getNumberOfNodes());

/*	insertByPos(100,1);
	display();
	printf("Count:%d\n", getNumberOfNodes());

	insertByPos(200,12);
	display();
	printf("Count:%d\n", getNumberOfNodes());

	insertByPos(300,7);
	display();
	printf("Count:%d\n", getNumberOfNodes());
*/	
	

/*	for(i=0;i<10;i++)
	{
		deleteFirst();
		display();
		printf("Count:%d\n", getNumberOfNodes());
	}
*/

}






