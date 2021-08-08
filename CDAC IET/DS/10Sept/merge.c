#include<stdio.h>

int i;
int arr[]={5,17,25,10};
int brr[]={55,65,15,20};
int crr[8];

void fun(int *arr,int size)
{
for(i=0;i<size;i++)
{
 crr[i]=arr[i];
 
}
}
void fun2(int *brr,int size)
{

for(i=0;i<size;i++)
{
 crr[i+4]=brr[i];
}

}

void display(int *crr,int l)
{
int i=0;
	while(i!=l)
	{
		printf("%d ",crr[i]);
		i++;
	}
}

void swap(int *arr,int *brr)
{
 int temp;
 temp=*arr;
 *arr=*brr;
 *brr=temp;
}



void bubble(int *crr,int size)
{
	
	for(int i=0;i<size;i++)
	{
		for(int j=0;j<size;j++)
		{
			if(crr[j]>crr[j+1])
			{
				swap(&crr[j],&crr[j+1]);
			} 
		}
	}
	
	



}





int main()
{

fun(arr,4);
fun2(brr,4);
bubble(crr,8);
display(crr,8);
}

