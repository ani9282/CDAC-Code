#include<iostream>
using namespace std;
#include<cstring>
#include<cstdlib>
class ABC
{
char *ptr;
int i;
public:
 ABC();
 ABC(const char* x);
 ABC(const ABC &c);
 void operator=(const ABC &c);
 ABC operator+(const ABC &c);
ABC operator+(int c);
friend ABC operator+(int y,ABC &c);
//ABC ABC::operator+(const char* c);
void display();
~ABC();

//friend ostream& out(

};

