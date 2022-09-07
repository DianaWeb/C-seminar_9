int Sum(int n)
{
	if (n == 0) return 0;
	else return n + Sum(n - 1);

	/* int i = n;
	if (i == 0) return 0;
	else return i + Sum(i - 1); */
}

int Sum2(int n)
{
	int sum = 0;
	for (int i = n; i > 0; i--)
	{
		sum += i;
	}
	return sum;
}

System.Console.WriteLine(Sum(5));
System.Console.WriteLine(Sum2(5));