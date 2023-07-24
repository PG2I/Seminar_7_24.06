// 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

Console.Write("Кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Искомое число: ");
int a = int.Parse(Console.ReadLine()!);

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

string FindNum(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++ )
        {
            if (arr[i,j] == num) return $"[{i+1}, {j+1}]"; 
        }
    }
    return "Not find";
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(FindNum(matrix, a));
