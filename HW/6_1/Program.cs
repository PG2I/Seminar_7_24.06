

Console.WriteLine("Размер массива:");
    int size = int.Parse(Console.ReadLine()!);
    Console.WriteLine("from:");
    int from = int.Parse(Console.ReadLine()!);
    Console.WriteLine("to:");
    int to = int.Parse(Console.ReadLine()!);

    int[] originalArray = new int[size];
    FillArray(originalArray, from, to);

    int[] copyArray = CopyArray(originalArray);

    Console.WriteLine("Исходный массив:");
    Print(originalArray);

    Console.WriteLine("Копия массива:");
    Print(copyArray);


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

static int[] CopyArray(int[] source)
{
    int size = source.Length;
    int[] destination = new int[size];
    for (int i = 0; i < size; i++)
    {
        destination[i] = source[i];
    }
    return destination;
}