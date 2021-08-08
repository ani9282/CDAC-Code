#include<iostream>
#include<ostream>
using namespace std;
#include"Node.h"
#include"LinkList.h"

int main()
{
LinkList l1;
/*l1.insert(10);
l1.insert(20);
l1.insert(30);
l1.append(30);*/

int i;
/*
for(i=0;i<10;i++)
{
	l1.insert(i);
	l1.append(i);
	
	
	l1.delete_first();
	
};

cout<<l1<<endl;/*
l1.append(20);
l1.append(30);
l1.insert(40);
cout<<l1<<endl;*/
l1.append(20);
l1.append(30);
l1.append(40);
l1.append(50);
//l1.insert(40);
cout<<l1<<endl;




LinkList l2(l1);
cout<<"==================="<<endl;
cout<<l1<<endl;
cout<<l2<<endl;
}
