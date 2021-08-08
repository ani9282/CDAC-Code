#include"Violin.h"
Violin::Violin()
{
cout<<"Violin::Violin"<<endl;

}


Violin::Violin(int t):Instrument(t)
{
cout<<"Violin::Violin()"<<endl;
}

Violin::~Violin()
{

cout<<"Violin::~Violin"<<endl;

}

Violin::Violin(const char *p,int c):Instrument(p,c)
{

}

void Violin::speak()
{
cout<<"Violin voice"<<endl;

}

