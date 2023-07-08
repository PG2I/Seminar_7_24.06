// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Enter number of quarters: ");
int quarter =int.Parse(Console.ReadLine()!);

void Quarters(int quarter)
{
    if (quarter > 4 || quarter < 1) System.Console.WriteLine("Error");
    else if (quarter == 1) System.Console.WriteLine("x > 0 && y > 0");
    else if (quarter == 2) System.Console.WriteLine("x < 0 && y > 0");
    else if (quarter == 3) System.Console.WriteLine("x < 0 && y < 0");
    else if (quarter == 4) System.Console.WriteLine("x > 0 && y < 0");
}
   

Quarters(quarter);