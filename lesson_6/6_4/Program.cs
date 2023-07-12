// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

 Console.WriteLine("Количество чисел:");
        int n = int.Parse(Console.ReadLine()!);

    static void PrintFibonacciNumbers(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("Неверно введено число.");
            return;
        }

        int first = 0;
        int second = 1;
        
        Console.Write("Число Фибоначчи:");
        Console.Write($" {first} {second}");

        for (int i = 2; i < n; i++)
        {
            int next = first + second;
            Console.Write($" {next}");
            first = second;
            second = next;
        }

    }

     PrintFibonacciNumbers(n);