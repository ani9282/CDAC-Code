#include<iostream>
#include<ostream>
#include<cstring>
#include<cstdlib>
using namespace std;
#ifndef _Student__h_
#define _Student__h_

class Student
{
char *name;
int id;
public:

Student(const char* name,int id);
~Student();
//Student(Student &x);
//void operator=(Student&x);
friend ostream& operator<<(ostream& out,Student &x);
char* getName(){return name;}
bool issamename(Student &x);
bool issameid(Student &x);
int getId(){return id;}
};

#endif
