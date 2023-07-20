// 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

Console.Write("Кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, cols];

void FillArray(int[,] matrix)
{
    Console.Write("Минимальное значение: ");
    int minValue = int.Parse(Console.ReadLine()!);
    Console.Write("Максимальное значение: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
}


void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]} ");
}
Console.WriteLine();
}
}

void Replacing(int[,] arr)
{
if (cols != rows)
Console.WriteLine("Не повернуть!");
else
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
for (int j = 0; j < i; j++)
{
    (arr[i,j], arr[j,i]) = (arr[j,i], arr[i,j]);
}
    }
}   
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Replacing(matrix);
PrintArray(matrix);