 // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Размер массива:");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("from:");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("to:");
int to = int.Parse(Console.ReadLine()!);
 
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

    static int SumElementsAtOddPositions(int[] arr)
    {
        int sum = 0;
        int size = arr.Length;
        for (int i = 0; i < size; i += 2)
        {
            sum += arr[i];
        }
        return sum;
    }

   
        int[] array = new int[size];
        FillArray(array, from, to);

        Console.WriteLine("Массив:");
        Print(array);

        int sum = SumElementsAtOddPositions(array);
        Console.WriteLine($"Сумма элементов на нечётных позициях: {sum}");