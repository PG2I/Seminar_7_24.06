Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int degree = int.Parse(Console.ReadLine()!);


int PrintNumber(int num, int degree)
{
    if (degree == 0) return 1;
    return PrintNumber(num,degree-1)*num;
}

PrintNumber(num, degree);

Console.Write($"{PrintNumber(num, degree) }");