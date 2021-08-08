#include<iostream>
using namespace std;
#include<cstring>
#include<cstdlib>
#ifndef _Animal__h_
#define _Animal__h_
class Animal
{
char *ptr;
int i,month;
public:
Animal();
Animal(int t);
Animal(const char *p,int c);
~Animal();
virtual void speak()=0;
bool operator>(Animal &s);
Animal(Animal &r);
//void operator=(Animal &a);
friend ostream& operator<<(ostream& out,Animal &r);
};
#endif
