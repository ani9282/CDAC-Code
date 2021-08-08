#include<iostream>
using namespace std;
#include<cstdlib>
#include<cstring>
#include"Violin.h"
#include"Instrument.h"
#include"Guitar.h"
int main()
{
/*
Instrument *ptr=new Instrument();//speak is pure virtual function (abstract class)
ptr->speak();*/

Violin d;
d.speak();

}
