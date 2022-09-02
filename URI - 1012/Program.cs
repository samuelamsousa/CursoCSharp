using System;
using System.Globalization;

namespace URI___1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string parametro = Console.ReadLine();
            string[] vetorparametro = parametro.Split(' ');

            double A = double.Parse(vetorparametro[0],CultureInfo.InvariantCulture);
            double B = double.Parse(vetorparametro[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vetorparametro[2], CultureInfo.InvariantCulture);
            double raio = 3.14159;

            Console.WriteLine("TRIANGULO: " + (A * C / 2) .ToString("F3"),CultureInfo.InvariantCulture);
            Console.WriteLine("CIRCULO: " + (raio * Math.Pow(C,2)).ToString("F3"),CultureInfo.InvariantCulture);
            Console.WriteLine("TRAPEZIO: "+ ((A + B) * C / 2).ToString("F3"),CultureInfo.InvariantCulture);
            Console.WriteLine("QUADRADO: " + (B * B).ToString("F3"),CultureInfo.InvariantCulture);
            Console.WriteLine("RETANGULO: " +( A * B).ToString("F3"),CultureInfo.InvariantCulture);
            
        }
    }
}
