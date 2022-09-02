using System;
using System.Globalization;

namespace URI___1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 2;
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 3;
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 5;

            Console.WriteLine("MEDIA = " + ((A + B + C) / 10).ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
