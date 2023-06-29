// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

/*Console.WriteLine("ВВедите число");
double A1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число произведений в степень");
int N = int.Parse(Console.ReadLIne()!);

if (N == 0)
{
    Console.WriteLine("Значение равно 1")
}
else do */

/*
int a = int.Parse(Console.ReadLine()!);
int count = 1;
if (a == 0 )
{
 Console.WriteLine("1");
}
else if ( a > 0 )
{
    while (Math.Pow(count,2) <= a)
    {
        Console.WriteLine(Math.Pow(count));
        count++;
    } 

}
*/

/*else if ( a < 0 )
    {
        while (Math.Pow(count,2) >= a )
        {
            Console.WriteLine(Math.Pow(count, 2));
             count--;
        }*/

int a = int.Parse(Console.ReadLine()!);
int count = 1;
if (a == 0 )
{
 Console.WriteLine("1");
}
else {
while (count <= Math.Abs(a) )
        {
            Console.WriteLine(Math.Pow(count, 2));
             count++;
        }
}