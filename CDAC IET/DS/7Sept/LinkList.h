#include<iostream>
#include<ostream>
using namespace std;

#ifndef _LinkList__h_
#define _LinkList__h_
#include"Student.h"
#include"Node.h"
class LinkList
{
Node *head;
public:
LinkList();
~LinkList();
friend ostream& operator<<(ostream& out,LinkList &x);
//LinkList(Student &x);
void insert(Student &x);
int getIdbyname(const char* name);
char* getNameByID(int x);
};

#endif
