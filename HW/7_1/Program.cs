Console.Write("Кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[rows, cols];

Console.Write("Минимальное значение: ");
double minValue = double.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение: ");
double maxValue = double.Parse(Console.ReadLine()!);

        
    void FillArray(double[,] matrix, double minValue, double maxValue)
    {
        Random RandNums = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Round(RandNums.NextDouble() * (maxValue - minValue) + minValue, 2);
            }
        }
    }

    void PrintArray(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++ )
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j], 5} " );
            }
            Console.WriteLine();
        }
    }

    FillArray(matrix, minValue, maxValue);
    PrintArray(matrix);
