#include<iostream>
#include<fstream>
using namespace std;
int main()
{
fstream ff("a.txt",ios::out);
int i=0;
while(i<5)
{
char temp[100];
cin>>temp;
ff<<temp<<endl;
i++;
}
ff.close();
//read file
cout<<endl;
fstream fi("a.txt",ios::in);
char tmp[100];

while(fi>>tmp)
{
cout<<tmp<<endl;
}
fi.close();
}



