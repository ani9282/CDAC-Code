#include<iostream>
using namespace std;
#include<cstring>
#include<cstdlib>
#ifndef _Instrument__h_
#define _Instrument__h_
class Instrument
{
char *ptr;
int i,month;
public:
Instrument();
Instrument(int t);
Instrument(const char *p,int c);
~Instrument();
virtual void speak()=0;
bool operator>(Instrument &s);
Instrument(Instrument &r);
//void operator=(Instrument &a);
friend ostream& operator<<(ostream& out,Instrument &r);
};
#endif
