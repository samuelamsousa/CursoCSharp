using System;

namespace Ex._03
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Criar programa para calculara media dos alunos
                double nota1;
                double nota2;
                double nota3;
                double media;
                string nome;

                Console.WriteLine("Digite nome do aluno");
                         nome = Console.ReadLine();

                Console.WriteLine("Digite nota 1");
                         nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite nota2 ");
                         nota2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite nota 3");
                         nota3 = double.Parse(Console.ReadLine());

                         media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine(" A media do Aluno  " + nome + " é " +  media);

                if (media <= 5)
                {
                    Console.WriteLine("Aluno Reprovado  ");
                }
                else
                {
                    Console.WriteLine("Aprovado");
                }
            }

        }
    }
}


