#include<iostream>
#include<ostream>
using namespace std;
#ifndef _Node__h_
#define _Node__h_
class Node
{
int data;
Node *next;
public:
Node();
Node(int x,Node* ptr);
~Node();
Node* getNext();
void setNext(Node*);
int getData();
void setData(int);
};
#endif
