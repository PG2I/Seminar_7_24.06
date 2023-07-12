

   
Console.WriteLine("Size array: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("from:");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("to:");
int to = int.Parse(Console.ReadLine()!);

    static void Print(double[] arr)
    {
        int size = arr.Length;
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

    static void FillArray(double[] arr, double from, double to)
    {
        int length = arr.Length;
        int index = 0;
        Random random = new Random();
        while (index < length)
        {
            double randomNumber = random.NextDouble() * (to - from) + from;
            arr[index] = Math.Round(randomNumber, 2);
            index++;
        }
    }

    static double FindDifference(double[] arr)
    {
        double min = arr[0];
        double max = arr[0];
        int size = arr.Length;
        for (int i = 1; i < size; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            else if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return Math.Round(max - min, 2);
    }

     double[] array = new double[size];
        FillArray(array, from, to);

        Console.WriteLine("Array:");
        Print(array);

        double difference = FindDifference(array);
        Console.WriteLine($"Difference: {difference}");