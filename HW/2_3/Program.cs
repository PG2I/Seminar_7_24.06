
       Console.WriteLine("Введите номер дня недели (1-7):");
        int dayNumber = int.Parse(Console.ReadLine()!);

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            bool isWeekend = IsWeekend(dayNumber);

            if (isWeekend)
            {
                Console.WriteLine("День является выходным.");
            }
            else
            {
                Console.WriteLine("День не является выходным.");
            }
        }
        else
        {
            Console.WriteLine("Такого дня недели не существует.");
        }


    static bool IsWeekend(int dayNumber)
    {
        // Проверяем, является ли день выходным (суббота или воскресенье)
        return (dayNumber == 6 || dayNumber == 7);
    }