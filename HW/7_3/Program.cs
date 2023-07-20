// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, cols];

Console.Write("Минимальное значение: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение: ");
int maxValue = int.Parse(Console.ReadLine()!);

void FillArray(int[,] matrix)
        {
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

        void FindColumnAverages(int[,] matrix)
        {
            for (int j = 0; j < cols; j++)
            {
                double sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += matrix[i, j];
                }
                double average = Math.Round(sum / rows, 2);
                Console.WriteLine($"Среднее арифметическое в столбце {j + 1}: {average}");
            }
        }

        FillArray(matrix);
        PrintArray(matrix);
        FindColumnAverages(matrix);
    