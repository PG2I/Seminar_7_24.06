// 1. Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("ВВедите длины тёх сторон:");
     int side1 = int.Parse(Console.ReadLine()!);
     int side2 = int.Parse(Console.ReadLine()!);
     int side3 = int.Parse(Console.ReadLine()!);
   
void CheckTriangleValidity(int a, int b, int c)
    {
      if (a + b > c && b + c > a && a + c > b)
     {
      Console.WriteLine("Треугольник может существовать.");
     }
      else
     {
        Console.WriteLine("Треугольник не существует.");
     }
    }

     CheckTriangleValidity(side1, side2, side3);