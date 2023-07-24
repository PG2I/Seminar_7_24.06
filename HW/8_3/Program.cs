//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Write("Кол-во строк первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов первой матрицы: ");
int cols1 = int.Parse(Console.ReadLine()!);

Console.Write("Кол-во строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов второй матрицы: ");
int cols2 = int.Parse(Console.ReadLine()!);

if (cols1 != rows2)
{
    Console.WriteLine("Матрицы не совпадают");
    return;
}

int[,] matrix1 = new int[rows1, cols1];
int[,] matrix2 = new int[rows2, cols2];

Console.Write("Минимальное значение: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение: ");
int maxValue = int.Parse(Console.ReadLine()!);

FillArray(matrix1, minValue, maxValue);
FillArray(matrix2, minValue, maxValue);

Console.WriteLine("Первая матрица:");
PrintArray(matrix1);

Console.WriteLine("Вторая матрица:");
PrintArray(matrix2);

int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

if (resultMatrix != null)
{
    Console.WriteLine("Результирующая матрица:");
    PrintArray(resultMatrix);
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

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    if (cols1 != rows2)
    {
        Console.WriteLine("Матрицы не совпадают");
        return null;
    }

    int[,] resultMatrix = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}
