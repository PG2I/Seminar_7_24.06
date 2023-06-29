 
 Console.WriteLine("Введите первое число:");
        int number1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите второе число:");
        int number2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите третье число:");
        int number3 = int.Parse(Console.ReadLine()!);

        int maxNumber = GetMaxNumber(number1, number2, number3);

        Console.WriteLine($"Максимальное число: {maxNumber}");

    static int GetMaxNumber(int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            return num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
        }
 