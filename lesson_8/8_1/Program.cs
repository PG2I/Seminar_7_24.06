// 1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.

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

void ReplacingLines(int[,] arr)

{
for (int j = 0; j < arr.GetLength(1); j++)
{
    (arr[0,j], arr[arr.GetLength(0)-1, j]) = (arr[arr.GetLength(0)-1, j], arr[0,j]);
}
Console.Write(arr);
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ReplacingLines(matrix);
PrintArray(matrix);