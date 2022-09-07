//64. Задайте значение М и N. напишите прог, которая выведет все натуральные числа в промежутке от М до N.

string Queue(int M, int N)
{
	if (M <= N) return $"{M} {Queue(M + 1, N)}";
	else return string.Empty;
}
System.Console.WriteLine(Queue(2, 8));

// тоже самое как:
string Queue2(int M, int N)
{
	string res = string.Empty;
	for (int i = M; i <= N; i++)
	{
		res = res + $"{i} ";
	}
	return res;
}
string res = Queue2(2, 6);
System.Console.WriteLine(res);
