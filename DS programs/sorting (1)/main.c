
#include <stdio.h>

enum TYPE {ascending=0, descending};

void swap(int *x, int *y)
{
	int tmp=*x;
	*x=*y;
	*y=tmp;
}

int part(int *arr, int l, int h)
{
	int j=l;
	int i=l;
	int p=h;
	
	while(j<p)
	{
		if(arr[j] < arr[p])
		{
			swap(&arr[j], &arr[i]);
			i++;
		}
		j++;
	}
	
	swap(&arr[i], &arr[p]);
	
	return i;
}

void quickSort(int *arr, int l, int h)
{
	if(l<h)
	{
		int index = part(arr, l, h);
		quickSort(arr,l,index-1);
		quickSort(arr,index+1,h);
	}
}


void bubbleSort(int arr[], int size, int type)
{
	int flag=0;
	int loop_count=0;
	int i,j=0;
	for(i=0;i<size-1;i++)
	{
		for(j=0;j<size-1;j++)
		{
			loop_count++;
			if(type == 0)
			{
				if(arr[j+1] < arr[j])
				{
					flag=1;
					swap(&arr[j+1], &arr[j]);
				}
			}
			else
			{
				if(arr[j+1] > arr[j])
				{
					flag=1;
					swap(&arr[j+1], &arr[j]);
				}
			} //else
		} //for j
	
	if(flag == 0)
		break;
	else
		flag=0;
	
	}// for i
	printf("\nloop_count:%d\n", loop_count);
}


void selectionSort(int arr[], int size, enum TYPE type)
{
	int i=0;
	while(i<size)
	{
		int tmp=arr[i];
		int j=i+1;
		while(j<size) 
		{
			if(type == ascending)
			{
				if(arr[j] < tmp)
				{
					swap(&arr[j], &tmp);
				}
				j++;

			}
			else
			{
				if(arr[j] > tmp)
				{
					swap(&arr[j], &tmp);
				}
				j++;
			}
		}
		arr[i]=tmp;
		i++;
	}
}

void insertionSort(int arr[], int size, int type)
{
	int loop_count=0;
	int i=1;
	while(i<size) 
	{
		int j=i;
		while(j>0)
		{
			loop_count++;;
			if(type == 0)
			{
				if(arr[j] < arr[j-1])
				{
					swap(&arr[j], &arr[j-1]);
				}
				else
					break;

				j--;
			}
			else
			{
				if(arr[j] > arr[j-1])
				{
					swap(&arr[j], &arr[j-1]);
				}
				else
					break;

				j--;
			}
			
		}
		i++;
	}
	printf("\nloop_count=%d\n", loop_count);
}
void mergesort()
{




}

void display(int *arr, int size)
{
	int i=0;
	while(i<size)
	{
		printf("%d, ", arr[i]);
		i++;
	}
	printf("\n----------------------------------\n");
}

int main()
{
	int arr[] = {2, 7, 1, 12, 20, 5 , 4};
	display(arr, 7);
	selectionSort(arr, 7, ascending);
        insertionSort(arr, 7, 0);
//	bubbleSort(arr, 7, 0);
	display(arr, 7);

}	




