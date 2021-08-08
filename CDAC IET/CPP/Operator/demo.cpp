#include"demo.h"
//#include<stdio.h>
ABC::ABC()
{
i=10;
ptr=new char[1];
strcpy(ptr,"gaikwad");
cout<<"ABC::ABC"<<endl;


}

ABC::ABC(const char* x)
{
i=20;
cout<<"ABC::ABC(char*)"<<endl;
//this->i=x;
//ptr=(char *)malloc(strlen(x)+1000000);
ptr=new char[strlen(x)+1];
strcpy(ptr,x);
//cout<<ptr<<endl;
}

void ABC::operator=(const ABC &c)
{
cout<<"inside equal to  operator"<<endl;
this->i=c.i;
free(this->ptr);
this->ptr=new char[strlen(c.ptr)+1];
strcpy(ptr,c.ptr);

}
/*
void ABC::operator=(const ABC &x)  //assignment operator
{
printf("inside assigment operator\n");
if(this!=&x)
{
	this->i=x.i;
	free(this->ptr);
	this->ptr=new char[strlen(x.ptr)+100000];
	strcpy(ptr,x.ptr);
}
}*/

ABC ABC::operator+(int c)
{
ABC temp;
temp.i=this->i+c;
return temp;
}

ABC ABC::operator+(const ABC &c)
{
cout<<"addition "<<endl;
ABC temp;
temp.i=this->i+c.i;
return temp;
}

ABC operator+(int y,ABC &c)
{
cout<<"............................"<<endl;
ABC temp;
temp.i=y+c.i;
return temp;
}

ABC ABC::operator+(const char* c)
{
ABC temp;
temp.ptr=this->ptr+c.ptr;
return temp;
}






ABC::ABC(const ABC &c)
{
this->i=c.i;
free(this->ptr);
this->ptr=new char[strlen(c.ptr)+1];
strcpy(this->ptr,c.ptr);
}

/*
ABC::ABC operator=(ABC &c)
{
free(this->ptr)
this->i=c.ptr
//strcpy();
}*/

void ABC::display()
{
cout<<i<<ptr<<endl;
}

ABC::~ABC()
{
i=0;
cout<<"ABC::~ABC"<<endl;
delete [] ptr;
}


