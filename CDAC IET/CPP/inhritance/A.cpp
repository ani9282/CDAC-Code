#include"A.h"

A::A()
{
cout<<"A::A"<endl;
}
A::~A()
{
cout<<"A::~A"<endl;

}
virtual void fun()
{

cout<<"virtual void fun"<<endl;

}

void fun2()
{
cout<<"void fun2"<<endl;


}
virtual void display()
{

cout<<"virtual void display"<<endl;

}
void display(int)
{

cout<<"void display"<<endl;

}


