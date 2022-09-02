using System;

namespace URI___1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string parametro = Console.ReadLine();
            string[] vetorparametro = parametro.Split(' ');

            int A = int.Parse(vetorparametro[0]);
            int B = int.Parse(vetorparametro[1]);
            int C = int.Parse(vetorparametro[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            int maiorBC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine($"{maiorBC} eh o maior");
        }
    }
}
