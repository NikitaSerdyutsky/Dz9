//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
Console.WriteLine("Введите натуральное число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine()!);
int sum = 0;

SumNumbers(M, N);

void SumNumbers(int M, int N)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    
    sum = sum + M;
    M++;
    SumNumbers(M, N);

}