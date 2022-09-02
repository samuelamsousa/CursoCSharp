using System;

namespace Ex._08___Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------- Programa para verificar se maior idade ----------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");

            int idade;

            Console.WriteLine(" Qual sua Idade ");
            idade = int.Parse(Console.ReadLine());

            Console.Clear();

            if (idade >= 18)
            {
                Console.WriteLine(" Voçê e maior de idade");
            }

            else
            {
                Console.WriteLine(" Voçê e menor de idade ");
            }

            Console.ReadLine();
        }
    }
}
