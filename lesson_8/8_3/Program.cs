// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9

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

int[] FriqDictionary(int[,] matrix)
{
    int[] FriqD = new int [maxValue + 1]; 
foreach (var i in matrix)
{
FriqD[i] += 1;
}
return FriqD;
}

void PrintMass (int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    
        Console.WriteLine($"{i} - {array[i]}");
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int[] NewMass=FriqDictionary(matrix);
PrintMass(NewMass);