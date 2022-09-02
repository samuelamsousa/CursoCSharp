using System;

namespace Ex._11___Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Criar programa para calcular a soma das notas de um aluno, e se media for maior ou igual a 6 
             * informa que o aluno foi aprovado. */

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("------------------- Programa calcular a nota media de um aluno ---------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");

            
            Console.Write(" Qual nome do aluno ");
            string nome = Console.ReadLine();
            Console.Write("Digite a primeiro nota do " + nome + ":");
            double N1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do " + nome + ":");
            double N2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota do " + nome + ":");
            double N3 = double.Parse(Console.ReadLine());
            double[] nota = { N2, N2, N3 };
            double media = (N1 + N2 + N3) / 3;
            Console.Clear();
            Console.WriteLine("Total de notas " + nota.Length);
            for (int n = 0; n < nota.Length; n++)
            {
                Console.WriteLine("nota " + nota[n]);
            }
            if (media >= 6)
            {
                Console.WriteLine("A media do Aluno e " + media);
                Console.WriteLine("Aluno " + nome + " Aprovado");
            }
            else
            {
                Console.WriteLine(media);
                Console.WriteLine("Aluno " + nome + " Reprovado");
            }

            Console.ReadLine();
            
        }
    }
}
