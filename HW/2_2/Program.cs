//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

 static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine()!);

        int thirdDigit = GetThirdDigitFromLeft(number);

        if (thirdDigit != -1)
        {
            Console.WriteLine("Третья цифра числa: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет!");
        }
    }

    static int GetThirdDigitFromLeft(int number)
    {
        int digitCount = CountDigits(number);

        if (digitCount >= 3)
        {
            return GetDigitAtPosition(number, digitCount - 3);
        }
        else
        {
            return -1;
        }
    }

    static int CountDigits(int number)
    {
        return (int)Math.Floor(Math.Log10(number) + 1);
    }

    static int GetDigitAtPosition(int number, int position)
    {
        int power = (int)Math.Pow(10, position);
        return (number / power) % 10;
    }
