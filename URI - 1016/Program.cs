using System;
using System.Globalization;

namespace URI___1016
{
    class Program
    {
        static void Main(string[] args)
        {
            string P1 = Console.ReadLine();
            string[] vetorP1 = P1.Split(' ');
            string P2 = Console.ReadLine();
            string[] vetorP2 = P2.Split(' ');
            
          
            double X1 = double.Parse(vetorP1[0], CultureInfo.InvariantCulture);
            double Y1 = double.Parse(vetorP1[1], CultureInfo.InvariantCulture);
            double X2 = double.Parse(vetorP2[0], CultureInfo.InvariantCulture);
            double Y2 = double.Parse(vetorP2[1], CultureInfo.InvariantCulture);
            double Distancia = Math.Sqrt(Math.Pow(X2 - X1, 2.00) + Math.Pow(Y2 - Y1, 2.00));
            Console.WriteLine(Distancia.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}
