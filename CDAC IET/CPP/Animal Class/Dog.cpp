#include"Dog.h"
Dog::Dog()
{
cout<<"Dog::Dog"<<endl;

}


Dog::Dog(int t):Animal(t)
{
cout<<"Dog::Dog()"<<endl;
}

Dog::~Dog()
{

cout<<"Dog::~Dog"<<endl;

}

Dog::Dog(const char *p,int c):Animal(p,c)
{

}

void Dog::speak()
{
cout<<"Dog voice"<<endl;

}

