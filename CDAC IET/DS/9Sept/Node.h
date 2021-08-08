#ifndef _Node__h_
#define _Node__h_
#include<iostream>
#include<ostream>
using namespace std;
class Node
{
int data;
Node* next;
public:
Node();
~Node();
Node(int x,Node* ptr);
void setNext(Node* next);
Node* getNext();
void setData(int data);
int getData();
friend class LinkList;
};
#endif
