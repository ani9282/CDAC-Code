/*
 ============================================================================
 Name        : demo.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>

int main(void)
{
	char str[10],str1[10];
	printf("enter string");
	scanf("%s",&str);
	strcpy(str1,str);
	int j;
	j=strlen(str)-1;
   for(int i=0;i<j;++i)
   {
	   char temp;
	   temp=str[i];
	   str[i]=str[j];
	   str[j]=temp;
	   j--;
   }
   printf("reverse=%s",str);

   if(*str==*str1)
   {
	   printf("\n palindrom string");
   }
   else
   {
	   printf("\n string not palindrom");
   }
}

