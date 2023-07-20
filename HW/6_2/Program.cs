// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void MNumbersMoreZero()
    {
        Console.WriteLine("Enter the number of numbers:");
        int count = int.Parse(Console.ReadLine()!);

        int positiveCount = 0;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Enter numbers: {i + 1}:");
            int number = int.Parse(Console.ReadLine()!);
            if (number > 0)
            {
                positiveCount++;
            }
        }

        Console.WriteLine($"Numbers more 0: {positiveCount}");
    }
    MNumbersMoreZero();
 

 /* Вариант для бесконечного ввода
 Console.Write("Сколько чисел?");
int M = int.Parse(Console.ReadLine()!);
int res=0;

for (int i = 1; i <= M; i++)
{
Console.WriteLine($"Введите {i} число ");
int a = int.Parse(Console.ReadLine()!);

if (a==0)
{
Console.WriteLine("Введеное число равно 0");
break;
}

else if (a>0) res=res+1;
}



Console.WriteLine($"Количество положительных чисел = {res} ");
*/