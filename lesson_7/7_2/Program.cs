// Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.



Console.Write("Кол-во строк ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];

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
void FillArray(int[,] matrix)
{
for (int i = 0; i < row; i++)
{
for (int j = 0; j < col; j++)
{
matrix[i, j] = i+j;
}

}
}
void SquarePositions(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i+=2)
{
    for (int j = 0; j < arr.GetLength(0); j+=2)
    {
        arr[i,j] *= arr[i,j];
    }
}
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SquarePositions(matrix);
PrintArray(matrix);