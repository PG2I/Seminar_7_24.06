//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


    Console.Write("Кол-во строк: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Кол-во столбцов: ");
    int cols = int.Parse(Console.ReadLine()!);

    int[,] matrix = new int[rows, cols];

    Console.Write("Минимальное значение: ");
    int minValue = int.Parse(Console.ReadLine()!);
    Console.Write("Максимальное значение: ");
    int maxValue = int.Parse(Console.ReadLine()!);

   
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

void SortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)

        for (int j = 0; j < matrix.GetLength(1) - 1; j++)

            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)

                if (matrix[i, k] < matrix[i, k + 1])

                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
}

 FillArray(matrix, minValue, maxValue);
    PrintArray(matrix);

    SortRows(matrix);
    Console.WriteLine("Массив после упорядочивания:");
    PrintArray(matrix);
