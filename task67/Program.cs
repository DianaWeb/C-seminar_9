// напишите прог. кот. будет принимать на вход число и возвращать сумму его цифр 
int sumDigit(int x)
{
	int sum = 0;
	while (x > 0)
	{
		sum = sum + x % 10;
		x = x / 10;
	}
	return sum;
}
System.Console.WriteLine(sumDigit(456));

int sumNum2(int x)
{
	if (x > 0) return x % 10 + sumNum2(x / 10);
	else return 0;
}
System.Console.WriteLine(sumNum2(456));