// 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.WriteLine("Enter size:");
int Size = int.Parse(Console.ReadLine()!);
int[] array = new int[Size];
Console.WriteLine("Enter from:");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter to:");
int to = int.Parse(Console.ReadLine()!);

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] arr, int from, int to)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(from, to + 1);
        index++;
    }
}

void RevMas(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size / 2; i++)
    {
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
    }
}


FillArray(array, from, to);
Console.WriteLine("Созданный массив:");
Print(array);
RevMas(array);
Console.WriteLine("Массив после обращения:");
Print(array);