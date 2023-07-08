// 1. Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число");
int Count (int num)
{
    int result = 0 ;
for (int i = 1; num != 0; i++)
{
    num/=10;
    result = i;
}
return result;
}
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(Count(A));
