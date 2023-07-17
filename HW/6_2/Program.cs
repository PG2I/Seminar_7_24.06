// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void MNumbersMoreZero()
    {
        Console.WriteLine("Enter the number of numbers:");
        int count = int.Parse(Console.ReadLine()!);

        int positiveCount = 0;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Enter numbers: {i + 1}:");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                positiveCount++;
            }
        }

        Console.WriteLine($"Numbers more 0: {positiveCount}");
    }
    MNumbersMoreZero();
 