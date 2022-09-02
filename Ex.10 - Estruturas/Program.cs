using System;

namespace Ex._10___Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar um programa que identifique se o numero e positivo ou negativo */

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("-------------------- Programa calcular metragem de apartamento----------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");

            double numero;

            Console.WriteLine(" Digite um numero ");
            numero = double.Parse(Console.ReadLine());

            Console.Clear();

            if (numero < 0)
            {
                Console.WriteLine(numero + " Esse numero e negativo");
            }
            else
            {
                Console.WriteLine(numero + " Esse numero e positivo");
            }

            Console.ReadLine();
        }
    }
}
