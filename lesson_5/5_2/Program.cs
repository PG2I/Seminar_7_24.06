// 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

Console.WriteLine("Enter size:");
int Size = int.Parse(Console.ReadLine()!);
int[] array = new int[Size];
Console.WriteLine("from:");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("to:");
int to = int.Parse(Console.ReadLine()!);

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
System.Console.WriteLine(arr[i]);
}
 
}
int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(from, to + 1);
        index++;
    }
    return arr;

}

void ChangeNums(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
arr[i] *= -1;
}
}
int[] mass = FillArray(Size, from, to);
PrintArray(mass);
ChangeNums(mass);
PrintArray(mass);








/*void ChangeNums(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
arr[i] *= -1;
}
}

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
System.Console.WriteLine(arr[i]);
}
}

int[] MassNums(int size, int from, int to)
{
int[] arr = new int[size];

for (int i = 0; i < size; i++)
{
arr[i] = new Random().Next(from, to + 1);
}
return arr;
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);


int[] mass = MassNums(a, b, c);
PrintArray(mass);
ChangeNums(mass);
PrintArray(mass);
*/