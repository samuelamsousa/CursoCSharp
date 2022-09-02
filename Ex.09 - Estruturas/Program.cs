using System;

namespace Ex._09___Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar programa para calcular o metro quadrado de um apartamento, se o apartamento for memor que 50 metros quadrado
             deverar informar apartamento compactor se não apartamento super luxo.*/

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("-------------------- Programa calcular metragem de apartamento----------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");

            double largura, comprimento, metroT;

            Console.WriteLine("digite a largura do apartamento ");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do apartamento");
            comprimento = double.Parse(Console.ReadLine());

            metroT = largura * comprimento;

            if (metroT <= 50)
            {
                Console.WriteLine("apartamento compacto");
                Console.WriteLine("Seu apartamento e de " + metroT);
            }

            else
            {
                Console.WriteLine("A aprtamento super LUXO");
                Console.WriteLine("Seu apartamento e de " + metroT);
            }

            Console.ReadLine();


        }
    }
}
