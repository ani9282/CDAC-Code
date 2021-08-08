#include<iostream>
#include<istream>
#include<ostream>
using namespace std;
#include<cstring>
#include<cstdlib>
class String
{
char *str;
public:
String(const char* x);
~String();
String(const String &c);
void operator=(const String &c);
String operator+(const char* p);
friend istream& operator>>(istream& in, String &p);
friend ostream& operator<<(istream& out, String &p);

void display();

};
