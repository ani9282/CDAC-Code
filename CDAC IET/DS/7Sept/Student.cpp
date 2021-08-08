#include"Student.h"



Student::Student(const char* name,int id)
{
this->name=new char[strlen(name)+1];
strcpy(this->name,name);
//name[strlen(name)]='\0';
this->id=id;
}


Student::~Student()
{

delete []this->name;

}

/*
void Student::operator=(Student& x)
{
this->name=x.name;
this->id=id;

}*/

ostream& operator<<(ostream& out,Student &x)
{
out<<x.name<<endl;
out<<"PRN::"<<x.id<<endl;
return out;

}/*
Student::Student(Student &x)
{
		this->name = new char[strlen(x.name)+1];
		strcpy(this->name, x.name);
		this->name[strlen(x.name)]='\0';	
		this->id = x.id;
}*/



bool Student::issamename(Student &x)
{
  if(!strcmp(this->name,x.name))
  
     return true;
  else
  
    return false;
  
}

bool  Student::issameid(Student &x)
{
	if(this->id==x.id)
	{
	return true;
	}
	else
	{
	return false;
	}
}



