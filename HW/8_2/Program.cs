

Console.Write("Кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, cols];

Console.Write("Минимальное значение: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Максимальное значение: ");
int maxValue = int.Parse(Console.ReadLine());

FillArray(matrix, minValue, maxValue);
PrintArray(matrix);

int minRowIndex = FindMinSumRowIndex(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1} строка");


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

