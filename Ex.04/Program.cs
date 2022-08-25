using System;
using System.Globalization;

namespace Ex._04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para calcular o aumento de salario de um funcionario X, exibindo 
            // % de aumento  do salario 
            // aumento em real
            // salario final

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("------------------ Progamade aumento de salario --------------------");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine(" ------------------ O nome do funcionario X --------------");
            string nome = Console.ReadLine();

            Console.WriteLine("------------------- Digite o salario do funcionario -------");
            double salarioInicial = double.Parse(Console.ReadLine());

            Console.WriteLine(" Qual % de aumento deseja para o funcionario " + nome + " ? ");
            double percet = double.Parse(Console.ReadLine());

            double percemdecimal = percet / 100;
            double salarioFinal = salarioInicial + salarioInicial * percemdecimal;


            Console.Clear();

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("-------------------------- Salario Atual ---------------------------");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Salario incial " + salarioInicial);
            Console.WriteLine(" Aumento em % " + percet);
            Console.WriteLine(" salario final " + salarioFinal .ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
