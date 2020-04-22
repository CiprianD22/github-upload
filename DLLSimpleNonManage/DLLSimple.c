#include <stdio.h>
#include <stdlib.h>

__declspec(dllexport) double doubleNext(double d)
{
	return d + 0.22;
}

__declspec(dllexport) int intNext(int i)
{
	return i + 2;
}

__declspec(dllexport) char* testString()
{
	char* chaine = (char*)malloc(sizeof(char) * 6);
	chaine[0] = 'M';
	chaine[1] = 'e';
	chaine[2] = 'O';
	chaine[3] = 'w';
	chaine[4] = 0;

	return chaine;
}

__declspec(dllexport) void remplirMemoireChaine(char* mem, int nbCar)
{
	int i = 0;
	while (i < nbCar - 1)
	{
		for (char j = '0'; j <= '9' && i < nbCar - 1; j++)
		{
			mem[i] = j;
			i++;
		}
	}
	mem[i] = 0;
}