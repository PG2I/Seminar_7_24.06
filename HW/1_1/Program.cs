
Console.WriteLine("Введите первое число:");
        int number1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите второе число:");
        int number2 = int.Parse(Console.ReadLine()!);

        if (number1 > number2)
        {
            Console.WriteLine($"{number1} больше.");
            Console.WriteLine($"{number2} меньше.");
        }
        else if (number1 < number2)
        {
            Console.WriteLine($"{number2} больше.");
            Console.WriteLine($"{number1} меньше.");
        }
        else
        {
            Console.WriteLine("Числа равны.");
            }
