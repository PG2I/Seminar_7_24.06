{
Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Четные числа от 1 до {0}:", number);
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            
                Console.WriteLine(i);
        }
}