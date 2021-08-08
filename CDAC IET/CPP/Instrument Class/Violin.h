#include<iostream>
using namespace std;
#include<cstring>
#include<cstdlib>
#include"Instrument.h"
#ifndef _Violin__h_
#define _Violin__h_
class Violin:public Instrument
{
public:
Violin();
Violin(int t);
Violin(const char *p,int c);
~Violin();
void speak();

};
#endif
