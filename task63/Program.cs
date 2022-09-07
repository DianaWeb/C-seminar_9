//63. Задайте значение N. напишите прог, которая выведет все натуральные числа в промежутке от 1 до N.


string Queue(int N)
{
	// string result = string.Empty;
	if (N == 0) return "";
	else return $"{N}, {Queue(N - 1)}";
}
System.Console.WriteLine(Queue(5));
