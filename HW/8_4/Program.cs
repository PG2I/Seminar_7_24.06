// Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


Console.Write("Кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, cols];

Console.Write("Минимальное значение: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение: ");
int maxValue = int.Parse(Console.ReadLine()!);

FillArray(matrix, minValue, maxValue);

Console.WriteLine("Оригинальный массив:");
PrintArray(matrix);

int minElement = int.MaxValue;
int minRow = -1;
int minCol = -1;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (matrix[i, j] < minElement)
        {
            minElement = matrix[i, j];
            minRow = i;
            minCol = j;
        }
    }
}

if (minRow >= 0 && minCol >= 0)
{
    int[,] resultMatrix = RemoveRowAndColumn(matrix, minRow, minCol);

    Console.WriteLine("Массив без наименьшего элемента:");
    PrintArray(resultMatrix);
}
else
{
    Console.WriteLine("Массив пуст или не содержит наименьшего элемента.");
}

int[,] RemoveRowAndColumn(int[,] matrix, int row, int col)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    int[,] resultMatrix = new int[rows - 1, cols - 1];

    for (int i = 0, k = 0; i < rows; i++)
    {
        if (i == row) continue;

        for (int j = 0, l = 0; j < cols; j++)
        {
            if (j == col) continue;

            resultMatrix[k, l] = matrix[i, j];
            l++;
        }

        k++;
    }

    return resultMatrix;
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

void FillArray(int[,] matrix, int minValue, int maxValue)
{
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
}

