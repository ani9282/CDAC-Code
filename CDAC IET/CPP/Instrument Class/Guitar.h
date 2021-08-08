#include<iostream>
using namespace std;
#include<cstring>
#include<cstdlib>
#include"Instrument.h"
#ifndef _Guitar__h_
#define _Guitar__h_
class Guitar:public Instrument
{
public:
Guitar();
Guitar(const char *p,int c);
~Guitar();
void speak();
};
#endif
