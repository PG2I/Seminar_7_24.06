/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

static int SumNum(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10; 
            sum += digit; 
            number /= 10; 
        }

        return sum;
    }
     Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);
        int sum = SumNum(number);
        Console.WriteLine("Сумма цифр в числе: " + sum);