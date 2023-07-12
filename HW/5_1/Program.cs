
    
        Console.WriteLine("Введите размер массива:");
        int size = int.Parse(Console.ReadLine()!);

    
    static void Print(int[] arr)
    {
        int size = arr.Length;
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

    static void FillArray(int[] arr, int from, int to)
    {
        int length = arr.Length;
        int index = 0;
        Random random = new Random();
        while (index < length)
        {
            arr[index] = random.Next(from, to + 1);
            index++;
        }
    }

    static int CountEvenNumbers(int[] arr)
    {
        int count = 0;
        int size = arr.Length;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

 int[] array = new int[size];

        FillArray(array, 100, 999);

        Console.WriteLine("Массив:");
        Print(array);

        int count = CountEvenNumbers(array);
        Console.WriteLine($"Чётные числа: {count}");