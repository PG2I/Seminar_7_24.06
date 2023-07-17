// 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

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
Console.WriteLine();

void SumDiagonal(int[,] array)
{
int sum = 0;
if (array.GetLength(0) != array.GetLength(1))
{
Console.WriteLine("Диагональ не ровная");
return;
}

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{

if (i == j)
{
sum = sum + array[i, j];
}


}
}
Console.Write($"{sum}");

}
FillArray(matrix);
PrintArray(matrix);
SumDiagonal(matrix);


