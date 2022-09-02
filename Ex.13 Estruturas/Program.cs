using System;

namespace Ex._13_Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------ Programa para verificar o horario -------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");

            double Time;

            Console.WriteLine("Digite o horario");
            Time = double.Parse(Console.ReadLine());

            if (Time >= 00 && Time <= 6) 
                {
                Console.WriteLine(" Boa Madrugada");
            }
            else if (Time >= 6 && Time <= 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (Time >= 12 && Time <=18)
            {
                Console.WriteLine("Boa tarde");
            }
            else if (Time >= 18)
            {
                Console.WriteLine("boa noite");
            }
            {

            }
        }
    }
}
