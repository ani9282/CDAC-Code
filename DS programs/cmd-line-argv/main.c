
#include <stdio.h>

int main(int argc, char *argv[])
{
	if(argc == 1)
	{
		printf("Please provide numbers to add...\n");
		return -1;
	}
	
	int x=1;
	int sum=0;
	while(x!=argc)
	{
		sum += atoi(argv[x]);
		x++;
	}

	printf("Sum=%d\n", sum);
	return 0;
}

