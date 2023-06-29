// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void rem(int a, int b)
{
    if (a % b == 0)
    Console.WriteLine("Числа кратны");
    else
    {
    Console.WriteLine("Число не кратно" + a % b);
    }   
}
int NumA = int.Parse(Console.ReadLine()!);
int NumB = int.Parse(Console.ReadLine()!);
rem(NumA,NumB);
