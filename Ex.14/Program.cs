using System;

namespace Ex._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------- Programa Para escolher dia da semana ------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");

            string semana;
            Console.WriteLine("digite o dia ");
            semana = Console.ReadLine();
            switch (semana)
            {
                case "1":
                    Console.WriteLine("Domingo");
                    break;
                case "2":
                    Console.WriteLine("Segunda");
                    break;
                case "3":
                    Console.WriteLine("terca");
                    break;
                case "4":
                    Console.WriteLine("quarta");
                    break;
                case "5":
                    Console.WriteLine("quinta");
                    break;
                case "6":
                    Console.WriteLine("sexta");
                    break;
                case "7":
                    Console.WriteLine("sabado");
                    break;

                default:
                    Console.WriteLine();
                    break;


            }
            Console.ReadLine();
        }
    }
}
