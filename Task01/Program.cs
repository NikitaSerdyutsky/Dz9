//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
Console.WriteLine("Введите натуральное число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine()!);



int SumNumbers(int M, int N)
{
    int sum = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        sum = M + SumNumbers(M, N);
        return sum;
    }
}

Console.Write(SumNumbers(M - 1, N));