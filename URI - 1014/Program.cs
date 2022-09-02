using System;
using System.Globalization;

namespace URI___1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int XKM = int.Parse(Console.ReadLine());
            double Ygas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(((XKM / Ygas).ToString("F3", CultureInfo.InvariantCulture) + " km/l"));

        }
    }
}
