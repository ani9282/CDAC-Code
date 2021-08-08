#include<iostream>
using namespace std;
#include<cstring>
#include<cstdlib>
#include"Animal.h"
#ifndef _Dog__h_
#define _Dog__h_
class Dog:public Animal
{
public:
Dog();
Dog(int t);
Dog(const char *p,int c);
~Dog();
void speak();

};
#endif
