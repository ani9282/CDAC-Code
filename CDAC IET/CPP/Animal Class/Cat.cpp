#include"Cat.h"

Cat::Cat()
{
cout<<"Cat::Cat"<<endl;

}

Cat::~Cat()
{

cout<<"Cat::~Cat"<<endl;
}

void Cat::speak()
{
cout<<"Cat Voice"<<endl;
}

Cat::Cat(const char *p,int c):Animal(p,c)
{


}
