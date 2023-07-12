// 2. Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

 Console.WriteLine("Введите десятичное число:");
        int decimalNumber = int.Parse(Console.ReadLine()!);

        string binaryNumber = DecimalToBinary(decimalNumber);
        
        Console.WriteLine($"Бинарное: {binaryNumber}");
    

string DecimalToBinary(int decimalNumber)
    {
        string binary = "";
        
        for (int i = decimalNumber; i > 0; i /= 2)
        {
            int remainder = i % 2;
            binary = remainder + binary;
        }

        return binary;
    }