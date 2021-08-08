#include"Animal.h"
Animal::Animal()
{
cout<<"Animal::Animal"<<endl;

}
Animal::Animal(int t)
{

month=t;
}

Animal::~Animal()
{

cout<<"Animal::~Animal"<<endl;
}

void Animal::speak()
{


}

Animal::Animal(const char *p,int c)
{
this->ptr=new char[strlen(p)+1];
strcpy(this->ptr,p);
this->i=c;
                                                      
}
/*
void Animal::operator=(Animal &r)
{
this->month=r.month;
}*/
ostream& operator<<(ostream& out,Animal &r)
{
out<<r.i<<endl;
out<<r.ptr<<endl;
}

bool Animal::operator>(Animal &s)
{
if(this->i>s.i)
{
return true;
}
else
{
return false;
}
}


Animal::Animal(Animal &r)
{
this->i=r.i;
}


