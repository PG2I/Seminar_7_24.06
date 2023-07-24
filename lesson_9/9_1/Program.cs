// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.


void PrintNumber(int num)
{
    if (num == 0)
     return;
    
    PrintNumber(num-1);
    Console.Write($"{num} ");
}
PrintNumber(5);