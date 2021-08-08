#include<stdio.h>
#include<string.h>
int palindrome(char *a);
int main()
{
int res;
char a[50];
printf("\n enter string");
scanf("%s",a);
res=palindrome(a);

if(res==1)
{
printf("\npalindrome");
}
else
{
printf("\nnot palindrome");
}

/*
int j;
j=strlen(a)-1;
for(int i=0;i<j;i++)
{
char temp=a[i];
		a[i]=a[j];
		a[j]=temp;
		j--;

}
printf("\n reverse=%s",a);


*/
}

int palindrome(char *a)
{
int j,i,flag;
j=strlen(a)-1;
for(i=0;i<j;i++)
{
if(a[i]==a[j])
{
flag=1;
j--;}
else
{
flag=0;
break;
}
return flag;
}
}
