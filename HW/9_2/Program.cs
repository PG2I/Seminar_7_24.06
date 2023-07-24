//Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.WriteLine("Введите M:");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите N:");
int N = int.Parse(Console.ReadLine()!);

int sum = SumNumbers(M, N);

Console.WriteLine($"Сумма натуральных элементов от {M} до {N}: {sum}");

int SumNumbers(int current, int N)
{
    if (current > N)
    {
        return 0; 
    }

    return current + SumNumbers(current + 1, N); // Суммируем текущее значение с результатом рекурсивного вызова функции для следующего числа.
}

SumNumbers(M, N);