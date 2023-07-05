  Console.WriteLine("Введите координаты точки A (x, y, z):");
        double x1 = double.Parse(Console.ReadLine()!);
        double y1 = double.Parse(Console.ReadLine()!);
        double z1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите координаты точки B (x, y, z):");
        double x2 = double.Parse(Console.ReadLine()!);
        double y2 = double.Parse(Console.ReadLine()!);
        double z2 = double.Parse(Console.ReadLine()!);

        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);
        Console.WriteLine("Расстояние между точками A и B: " + distance.ToString("F2"));

    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dz = z2 - z1;

        double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
        return distance;
    }