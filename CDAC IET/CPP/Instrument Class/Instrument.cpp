#include"Instrument.h"
Instrument::Instrument()
{
cout<<"Instrument::Instrument"<<endl;

}
Instrument::Instrument(int t)
{

month=t;
}

Instrument::~Instrument()
{

cout<<"Instrument::~Instrument"<<endl;
}

void Instrument::speak()
{


}

Instrument::Instrument(const char *p,int c)
{
this->ptr=new char[strlen(p)+1];
strcpy(this->ptr,p);
this->i=c;
                                                      
}
/*
void Instrument::operator=(Instrument &r)
{
this->month=r.month;
}*/
ostream& operator<<(ostream& out,Instrument &r)
{
out<<r.i<<endl;
out<<r.ptr<<endl;
}

bool Instrument::operator>(Instrument &s)
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


Instrument::Instrument(Instrument &r)
{
this->i=r.i;
}


