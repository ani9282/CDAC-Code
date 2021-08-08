int isFull()
{
	if( (f==r+1) || (f==0 && r==SIZE-1) )
		return 1;
	
	return 0;
}

int isEmpty()
{
	if(f==-1)
		return 1;
	else
		return 0;
}


void enqueue(int n)
{
	if(!isFull())
	{
		//first element???
		if(f==-1)
		{
			f=0;
		}

		if(r==SIZE-1)
			r=0;
		else
			r++;

		arr[r] = n;
		//displayQueue();
	}
	else
	{
		printf("Queue is full\n");
	}
}


int dequeue()
{
	int n;
	
	if(isEmpty())
	{
		printf("\nQueue is empty");
	}
	else if(r==f)
	{
		n=arr[f];
		r=f=-1;
		
	}
	else
	{
		n=arr[f];
		if(f==SIZE-1)
			f=0;
		else
			f++;
	}

return n;

}


void display()
{
	if(f==-1)
		printf("\nQueue is empty");
	else
	{
		int i=f;
		for(;i!=r;)
		{
			printf("%d <--", arr[i]);
			if(i==SIZE-1)
				i=0;
			else
				i++;
		}
		printf("%d <--", arr[i]);
		printf("\n");
	}	
}
