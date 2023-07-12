//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Enter size:");
int Size = int.Parse(Console.ReadLine()!);
int[] array = new int[Size];
Console.WriteLine("Enter from:");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter to:");
int to = int.Parse(Console.ReadLine()!);


void FillArray(int[] Size)
{
int length = Size.Length;
int index = 0;
while (index < length)
{
Size[index] = new Random().Next(from, to +1 );
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

FillArray(array);
PrintArray(array);