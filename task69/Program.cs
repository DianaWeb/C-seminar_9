// Наипишите прог., кот. на вхо принимает два числа А и В и возводит число А в целую степень В с помощью рекурсии. 
int Exponentiation(int A, int B)
{
	int res = 1;
	for (int i = 0; i < B; i++)
	{
		res = res * A;
	}
	return res;
}
System.Console.WriteLine(Exponentiation(3, 5));

int Exponentiation2(int A, int B)
{
	if (B > 0) return A * Exponentiation2(A, B - 1);
	else return 1;
}
System.Console.WriteLine(Exponentiation2(3, 5));