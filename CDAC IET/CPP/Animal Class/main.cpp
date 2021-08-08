#include<iostream>
using namespace std;
#include<cstdlib>
#include<cstring>
#include"Cat.h"
#include"Animal.h"
#include"Dog.h"
int main()
{
/*
Animal *ptr=new Animal();//speak is pure virtual function (abstract class)
ptr->speak();*/

Animal *dog=new Dog("Boss",7);
Animal *cat=new Cat("Pinky",2);

cout<<*dog<<endl;
cout<<*cat<<endl;

	if(dog>cat)
	{
	cat->speak();
	}
		else
		{

			dog->speak();
		}



	delete cat;
	delete dog;
	Dog d(10);
	d.speak();

}
