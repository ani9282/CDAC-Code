#include<iostream>
#include<fstream>
using namespace std;
int main()
{
int a,b,sum;
fstream ff;
ff.open("input.txt",ios::out);
cin>>a;
ff<<a<<endl;
cin>>b;
ff<<b<<endl;
ff.close();

fstream fo;
fo.open("input.txt",ios::in);
while(!ff.eof())
{
ff>>a;
ff>>b;
sum=a+b;
}
fo.close();
fstream fc;
fc.open("output.txt",ios::out);
fc<<sum<<endl;
fc.close();
}
