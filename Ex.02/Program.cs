using System;

namespace Ex._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar programa para calculara media dos alunos
            int nota1;
            int nota2;
            int media;
            string nome;
            Console.WriteLine("Digite nome do aluno");
            nome = Console.ReadLine();

            Console.WriteLine("Digite nota 1");
            nota1= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite nota2 ");
            nota2 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine(" A media do Aluno e " + media);

            if (media >= 5)
            {
                Console.WriteLine("Aprovado ");
            }
            else
            {
                Console.WriteLine("Aluno Rprovado kkk se ferro");
            }


        }
    }
}
