#include<stdio.h>
#define SIZE 6
void swap(int *x, int *y)
{
	int tmp=*x;
	*x=*y;
	*y=tmp;
}

int part(int *arr, int l, int h)
{
	int i=l-1;
	int j=l;
	int p=h;
	
	while(j<p)
	{
		if(arr[j]<arr[p])
		{
			i++;
			swap(&arr[i],&arr[j]);
			//j++;
		}
		j++;
	}
	i++;
	swap(&arr[i],&arr[p]);
	return i;
}

void quick_sort(int arr[],int l,int h)
{
	if(l<h)
	{
		int index = part(arr, l, h);
		quick_sort(arr,l,index-1);
		quick_sort(arr,index+1,h);
	}
}


void display(int *arr)
{
	printf("\n");//-------------------------------\n");
	for(int i=0;i<SIZE;i++)
	{
		printf("------");	
	}
	printf("\n");
	for(int i=0;i<SIZE;i++)
	{
		printf(" %d 👉️",arr[i]);	
	}
	printf("\n");
	for(int i=0;i<SIZE;i++)
	{
		printf("------");	
	}
	//printf("\n-------------------------------\n");	
}



void merge(int *arr,int l,int m,int h)
{
	int n1 = m-l+1;
	int n2 = h-m;
	int arr1[n1];
	int arr2[n2];
	for(int i=0;i<n1;i++)
		arr1[i] = arr[l+i];
	for(int i=0;i<n2;i++)
		arr2[i] = arr[m+1+i];
	
	int i=0;
	int j=0;
	int k=l;
	while(i<n1 && j<n2)
	{
		if(arr1[i] < arr2[j])
		{
			arr[k] = arr1[i];
			k++;
			i++;
		}
		else
		{
			arr[k] = arr2[j];
			k++;
			j++;		
		}
	}
	while(i<n1)
	{
		arr[k] = arr1[i];
		k++;
		i++;
	}
	while(j<n2)
	{
		arr[k] = arr2[j];
		k++;
		j++;
	}
}


void mergeSort(int *arr,int l,int h)
{
	if(l<h)
	{
		int m=(l+h)/2;
		mergeSort(arr,l,m);
		mergeSort(arr,m+1,h);
		merge(arr,l,m,h);	
	}
}



int main()
{
	int arr[]={1,5,9,12,3,25};
	//int arr[] = {2,5,3,1,12,18,11};	
	//printf("\nQuick Sort");	
	//quick_sort(arr,0,SIZE);
	mergeSort(arr,0,SIZE-1);			
	display(arr);	
	printf("\n\n");


	return 0;
}
