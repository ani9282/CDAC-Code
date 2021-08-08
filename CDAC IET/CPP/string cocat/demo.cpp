#include"demo.h"
String::String(const char* x)
{
str=new char[strlen(x)+1];
strcpy(this->str,x);

}

String::~String()
{
delete [] str;
cout<<"str::~str"<<endl;

}

String::String(const String &c)
{
free(this->str);
this->str=new char[strlen(c.str)+1];
strcpy(str,c.str);

}

void String::operator=(const String &c)
{
free(this->str);
this->str=new char[strlen(c)+1];
strcpy(str,c);

}
istream& operator>>(istream& in, String &p)
{
	in>>p.str;


}
ostream& operator<<(ostream& out, String &p)
{

	out<<p.str;
	


}
/*

String String::operator+(const String &c)
{
//free(this->str);
String temp;
temp.str=new char[strlen(this->str)+strlen(c.str)+1];
strcpy(temp.str,this->str);
strcat(temp.str,c.str);
return temp; 

}*/
/*
String String:: operator+(const char *p)
{
	
	String temp;
	temp.str=new char[strlen(this->str)+strlen(p)+1];
	strcpy(temp.str,this->str);
	strcat(temp.str,p);
	//cout<<temp.str<<endl;
	return temp;

}*/
void String::display()
{

cout<<"str="<<str<<endl;

}
