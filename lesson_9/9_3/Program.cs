// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int PrintNumber(int num)
{
    if (num/10 == 0)  return num;

   return PrintNumber(num/10) + num % 10;
}
PrintNumber(num);

Console.Write($"{PrintNumber(num) }");