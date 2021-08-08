
#ifndef __Student_H__
#define __Student_H__
#include <iostream>
#include <ostream>
using namespace std;

class Student
{
	char *name;
	int id;
	
public:
	Student(const char *str, int id);
	~Student();
	void operator=(Student &x);
	Student(Student &x);
	bool isSameId(Student &x);
	bool isSameName(Student &x);
	bool operator==(Student &x);
	friend ostream& operator<<(ostream& out, Student& x);
	char * getName() {return name;}
	int getID() {return id;}
};

#endif

