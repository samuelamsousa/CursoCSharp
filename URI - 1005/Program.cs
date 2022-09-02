using System;
using System.Globalization;

namespace URI___1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture) * 3.5;
            double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture) * 7.5;

            Console.WriteLine("MEDIA = " + ((A + B )/11).ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
