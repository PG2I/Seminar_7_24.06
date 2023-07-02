//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine()!);

        PrintThirdDigit(number);
    

    static void PrintThirdDigit(int number)
    {
        string numberString = number.ToString();

        if (numberString.Length >= 3)
        {
            char thirdDigit = numberString[2];
            Console.WriteLine("Третья цифра числа: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет!");
        }
    }