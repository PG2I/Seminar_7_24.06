// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

Console.WriteLine("Введите M:");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите N:");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine("Чётные числа от M до N:");
PrintEvenNumbers(M, N);


void PrintEvenNumbers(int current, int N)
{
    if (current > N)
        return;

    if (current % 2 == 0)
    {
        Console.Write($"{current} ");
    }

    PrintEvenNumbers(current + 1, N);
}