using System;
using System.Globalization;

namespace URI___1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fun = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            int horas = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double Htra = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine("NUMBER = " + Fun);
            Console.WriteLine($"SALARY = U$ { (horas * Htra).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
