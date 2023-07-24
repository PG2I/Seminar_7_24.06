// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

void PrintNumber(int N, int M)
{
    if (N < M)
     return;
    
    PrintNumber(N-1, M);
    Console.Write($"{N} ");
}
PrintNumber(7, 2);
