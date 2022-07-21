// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> " 2, 4"
// M = 4; N = 8 -> "4, 6, 8"
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Sequence(int M, int N)
{
    if (N < M) return;
    Sequence(M, N-1);
    Console.Write($"{N}, ");
}
Sequence(M, N);


