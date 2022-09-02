using System;
using System.Globalization;

namespace URI___1010
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string peca1 = Console.ReadLine();
            string [] vetorpeca1 = peca1.Split(' ');

            string peca2 = Console.ReadLine();
            string[] vetorpeca2 = peca2.Split(' ');

            double QuantP1, QuantP2, ValoP1, ValorP2, total;

            QuantP1 = double.Parse(vetorpeca1[1]);
            ValoP1 = double.Parse(vetorpeca1[2], CultureInfo.InvariantCulture);
            QuantP2 = double.Parse(vetorpeca2[1]);
            ValorP2 = double.Parse(vetorpeca2[2],CultureInfo.InvariantCulture);
            total = (ValoP1 * QuantP1 + ValorP2 * QuantP2);


            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
