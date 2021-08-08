#include<stdio.h>
#pragma pack(1)
typedef struct 
{
int a;
char c;
}A;

int main()
{
 printf("%ld",sizeof(A));
}
