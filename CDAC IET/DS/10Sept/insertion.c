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

int main()
{
	int arr[]={7,4,5,2};
	int i,j;
	for(i=0;i<4;i++)
	{
		for(j=0;j<4;j++)
		{
			if(arr[j]>arr[j+1])
			{
				swap(&arr[j],&arr[j+1]);
			} 
		}
	}
	display(arr,4);
}




