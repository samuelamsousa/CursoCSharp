using System;
using System.Globalization;

namespace URI___1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double venda = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double SalarioCom = (salario + venda * 0.15);

            Console.WriteLine("TOTAL = R$ " + SalarioCom.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
