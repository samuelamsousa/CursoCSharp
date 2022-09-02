using System;
using System.Globalization;

namespace Uri._1001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("------------------------ Atividade URI - 1001 -------------------------");
            Console.WriteLine("----------------------------------------------------------------- -----");

            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area;
            area = (n * Math.Pow(raio, 2));



            Console.WriteLine("A=" + area.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}
