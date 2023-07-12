// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

Console.WriteLine("Enter size:");
int Size = int.Parse(Console.ReadLine()!);
int[] array = new int[Size];
Console.WriteLine("from:");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("to:");
int to = int.Parse(Console.ReadLine()!);

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

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
System.Console.Write(col[position] + " ");
position++;
}
}


void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg}");
}
FillArray(array, from, to);
PrintArray(array);
SumPosNeg(array);



/*void Print(int[] arr)
{
int size = arr.Length;

for (int i = 0; i < size; i++)
Console.Write($"{arr[i]} ");
Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
int[] arr = new int[size];

for (int i = 0; i < size; i++)
arr[i] = new Random().Next(from, to + 1);
return arr;
}

void SumPosNeg(int[] arr)
{
int pos, neg;
pos = neg = 0;

for (int i = 0; i < arr.Length; i++)
{
if (arr[i] >= 0)
pos += arr[i];
else
neg += arr[i];
}
Console.WriteLine($"Positive: {pos}, negative: {neg}");
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass);*/

