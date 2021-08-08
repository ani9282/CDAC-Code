#include<stdio.h>
void swap(int *arr,int *brr)
{
	int tmp=*arr;
	*arr=*brr;
	*brr=tmp;
}

void display(int *arr,int l)
{
	int i=0;
	while(i!=l)
	{
		printf("%d ",arr[i]);
		i++;
	}
}

void insertion(int *arr,int size)
{

	
	for(int i=0;i<size;i++)
	{
		
		for(int j=0;j<size;j++)
		{
			if(arr[j]>arr[j+1])
			{
				swap(&arr[j],&arr[j+1]);
			} 
		}
	}


}



void selection(int *arr,int size)
{

 	int i=0;
       while(i<size)
 	{
 	  int temp;
 	  temp=arr[i];
 	  int j=i+1;
 	  while(j<size)
 	  {
 	  	if(temp>arr[j])
 	  	{
 	  		swap(&temp,&arr[j]);
 	  	}
 	  	j++;
 	  }
 	  arr[i]=temp;
 	  i++;
 	}
 	

}

int main()
{
	int arr[4]={7,4,5,2},i;
	//insertion(arr,4);
	selection(arr,4);
	display(arr,4);
	
}



