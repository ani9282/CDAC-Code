
#include "Student.h"
#include <cstring>

Student::Student(const char *str, int id)
{	
	name = new char[strlen(str) + 1];
	strcpy(name, str);
	name[strlen(str)]='\0';
	this->id = id;
}

Student::~Student()
{	
	delete [] this->name;
}

void Student::operator=(Student &x)
{
	if(this != &x)
	{
		delete [] this->name;	
		this->name = new char[strlen(x.name)+1];
		strcpy(this->name, x.name);
		this->name[strlen(x.name)]='\0';	
		this->id = x.id;
	}
	
}

bool Student::isSameId(Student &x)
{
		if(this->id == x.id)
			return true;
		
		return false;
}

bool Student::isSameName(Student &x)
{
		if( !strcmp(this->name,x.name) )
			return true;
		
		return false;
}

bool Student::operator==(Student &x)
{
		if( !strcmp(this->name,x.name) )
		{
			if(this->id == x.id)
			return true;
		}
		return false;
}

Student::Student(Student &x)
{
		this->name = new char[strlen(x.name)+1];
		strcpy(this->name, x.name);
		this->name[strlen(x.name)]='\0';	
		this->id = x.id;
}

ostream& operator<<(ostream& out, Student& x)
{
	out<<"Student Name:"<<x.name<<", PRN:"<<x.id;
	return out;
}


