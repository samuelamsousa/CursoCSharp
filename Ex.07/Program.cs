using System;
using System.Globalization;

namespace Ex._07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler as medidas de largura e comprimento de um terreno retangular com uma casa decimal, bem como 
             * o valor do metro quadrado do terreno com duas casas decimais. em seguida, o programa deve mostrar o valor do terreno, bem
             * como o valor dopreço do metro com duas casas decimais.*/

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("------------------ Programade Calculo da Metragem de um terreno --------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");
            double largura, comprimento, valorMetro, metroQ, totalMetro;

            Console.WriteLine(" Digite largura do terreno ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Digite o comprimento ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Digite o Valor do Metro quadrado terreno  ");
            valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            metroQ = largura * comprimento;
            totalMetro = metroQ * valorMetro;

            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("------------------------------- Calculando --------------------------------------");

            Console.WriteLine($" Seu terreno tem " + metroQ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine(" Valor total do terreno e " + totalMetro.ToString("F2"),CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
