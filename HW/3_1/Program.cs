Console.WriteLine("Введите пятизначное число:");
        int number = int.Parse(Console.ReadLine()!);

        if (IsPalindrome(number))
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }

    static bool IsPalindrome(int number)
    {
        // Преобразуем число в строку для удобства проверки
        string numberString = number.ToString();

        // Проверяем, является ли строка палиндромом
        int left = 0;
        int right = numberString.Length - 1;

        while (left < right)
        {
            if (numberString[left] != numberString[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }