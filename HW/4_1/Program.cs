// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число - A");
double A = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число - B");
double B = double.Parse(Console.ReadLine()!);
double Product(double num)
{ 
    double result = 1;
   double abs_B = Math.Abs(B);

    for (double i = 1; i <= abs_B; i++)
    {
      
      if (B > 0)
        result *=  A;

        else
        result /= A;
    }
   
    return result;
    
}

double result = Product(A);
Console.WriteLine("Результат " + result);
