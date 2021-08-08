#include"Guitar.h"

Guitar::Guitar()
{
cout<<"Guitar::Guitar"<<endl;

}

Guitar::~Guitar()
{

cout<<"Guitar::~Guitar"<<endl;
}

void Guitar::speak()
{
cout<<"Guitar Voice"<<endl;
}

Guitar::Guitar(const char *p,int c):Instrument(p,c)
{


}
