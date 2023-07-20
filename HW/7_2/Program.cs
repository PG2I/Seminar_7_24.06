// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве. 
// B возвращает значение этого элемента или же указание, что такого элемента нет.



Console.Write("Кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, cols];

Console.Write("Минимальное значение: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение: ");
int maxValue = int.Parse(Console.ReadLine()!);

Console.Write("Введите число для поиска: ");
int numberToFind = int.Parse(Console.ReadLine()!);


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

    string FindElementPosition(int[,] matrix, int numberToFind)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == numberToFind)
                {
                    return $"Значение {numberToFind} найдено в строке {i+1} и столбце {j+1}.";
                }
            }
        }

        return "Значение не найдено.";
    }
FillArray(matrix, minValue, maxValue);

string positionInfo = FindElementPosition(matrix, numberToFind);

Console.WriteLine(positionInfo);

Console.WriteLine();
PrintArray(matrix);
