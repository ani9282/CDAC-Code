#include<iostream>
#include<ostream>
using namespace std;
#include"Student.h"
#include"LinkList.h"
#ifndef _Node__h_
#define _Node__h_

class Node
{

Student data;
Node* next;

public:
Node(Student &x);
~Node();
friend ostream& operator<<(ostream& out,Node &x);
friend class LinkList;
Node* getNext(){return next;}
Student getData(){return data;}
};

#endif
