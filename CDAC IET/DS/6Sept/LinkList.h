#include<iostream>
#include <ostream>
using namespace std;
#ifndef _LinkList__h_
#define _LinkList__h_
#include"Node.h"
class LinkList
{
Node* head;

public:
LinkList();
~LinkList();
LinkList(int data);
void insert(int data);
void append(int data);
void delete_first();
friend ostream& operator<<(ostream& out,LinkList& x);
LinkList(LinkList &r);
};
#endif
