#ifndef _LinkList__h_
#define _LinkList__h_
#include<iostream>
#include<ostream>
using namespace std;
#include"Node.h"
class LinkList
{
Node* head;
public:
LinkList();
LinkList(int data);
~LinkList();
void insert(int data);
void append(int data);
void delete_first();
friend ostream& operator<<(ostream& out,LinkList&);
};
#endif
