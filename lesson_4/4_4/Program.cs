// 3. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

/*void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(0, 2);
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

int[] array = new int[8];


FillArray(array);
PrintArray(array);*/

/*void FillArray(int[] collection)
{
for (int i = 0; i < collection.Length; i++)
{
collection[i] = new Random().Next(0,2);
i++;
}
}
void printArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count )
{
Console.Write(col[position]+",");
position++;

}
}
int[] array = new int[5];
FillArray(array);
printArray(array);*/

//Массив с произвольными значениями и заданной длиной
Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine()!);
int[] arr = new int[length];

void MassConf(int[] arr)
{
for (int i = 0; i < length; i++)
{
arr[i] = new Random().Next();
}
}
void PrintArray(int[] arr)
{
var str = string.Join(" ", arr);
Console.Write($"{str} ");
}
MassConf(arr);
PrintArray(arr);
