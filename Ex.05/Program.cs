using System;
using System.Globalization;

namespace Ex._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");         
            Console.WriteLine("--------------Progama Caixa  ------------------");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Incira o nome do produto");
            string produto = Console.ReadLine();
            Console.WriteLine("Digite valor do produto");
            double valorProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("valor dinheiro");
            double dinheiro = double.Parse(Console.ReadLine());
            double troco = dinheiro-valorProduto;

            Console.Clear();
            

            if (dinheiro <= valorProduto)
            {
                Console.WriteLine("Produto " + produto);
                Console.WriteLine("Valor" + valorProduto);
                Console.WriteLine("Dinheiro " + dinheiro);
                Console.WriteLine();
                Console.WriteLine(" Não tem troco");

            }
            else
            {
                Console.WriteLine("Produto " + produto);
                Console.WriteLine("Valor " + valorProduto);
                Console.WriteLine("Dinheiro" + dinheiro);
                Console.WriteLine();
                Console.WriteLine($"Seu troco e  " + troco.ToString("F2", CultureInfo.InvariantCulture));
            }


            Console.ReadLine();

        }
    
    }
}
