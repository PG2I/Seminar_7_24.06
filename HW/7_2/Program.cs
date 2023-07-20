 Console.Write("Кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, cols];

Console.Write("Минимальное значение: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение: ");
int maxValue = int.Parse(Console.ReadLine()!);



Console.Write("Введите номер строки: ");
int rowNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int colNumber = int.Parse(Console.ReadLine()!);

int element = GetElement(matrix, rowNumber, colNumber);

        if (element != int.MinValue)
        {
            Console.WriteLine($"Значение элемента: {element}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет в массиве.");
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

 int GetElement(int[,] matrix, int row, int col)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (row >= 0 && row < rows && col >= 0 && col < cols)
        {
            return matrix[row, col];
        }

        return int.MinValue;
    }

    FillArray(matrix, minValue, maxValue);
    PrintArray(matrix);