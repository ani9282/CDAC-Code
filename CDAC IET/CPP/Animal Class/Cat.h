#include<iostream>
using namespace std;
#include<cstring>
#include<cstdlib>
#include"Animal.h"
#ifndef _Cat__h_
#define _Cat__h_
class Cat:public Animal
{
public:
Cat();
Cat(const char *p,int c);
~Cat();
void speak();
};
#endif
