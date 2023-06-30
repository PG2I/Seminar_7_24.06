 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
    int number = int.Parse(Console.ReadLine()!);

    int secondDigit;

    if (number >= 100 && number <= 999)
     {
         secondDigit = ((number / 10) % 10);
    }
    else
    {
        Console.WriteLine("Введено некорректное число!");
        return;
    }

    Console.WriteLine("Вторая цифра числа: " + secondDigit);