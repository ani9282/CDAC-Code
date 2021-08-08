#include"demo.h"
int main()
{
ABC a;
a.display();
ABC b("anirudha");
b.display();
a=b;
a.display();
b.display();


//ABC c(10);
//c.display;
a=b;
b.display();
ABC c;
c=a+b;
c.display();

ABC d;
d=a+50;
d.display();

ABC e;
e=60+a;
e.display();


}
