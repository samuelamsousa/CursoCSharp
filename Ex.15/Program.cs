using System;

namespace Ex._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i <= 5) 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 5);

            //var indice = 0;
            //var verçoes = new [] { 1.1, 1.2, 2.0, 3.0, 4.0};
            //while (indice <= verçoes.Length)
            //{
            //    Console.WriteLine(verçoes[indice]);
            //    indice++;
            //}



            //    var contador = 10;
            //    var opc = "";
            //do 
            //{ 
            //    Console.WriteLine("Digire a opção");
            //    Console.WriteLine("1 - saque |2 - Deposito | 3 - saldo |4 - sair");
            //    opc = Console.ReadLine();


            //    switch (opc)
            //    {
            //        case "1":
            //            Console.WriteLine("Saque selecionado");
            //            break;
            //        case "2":
            //            Console.WriteLine("Deposito selecionado");
            //            break;
            //        case "3":
            //            Console.WriteLine("Saldo selecionado");
            //            break;
            //        case "4":
            //            Console.WriteLine("sair");
            //            break;
            //        default:
            //            Console.WriteLine("Opção invalida");
            //            break;
            //    }
            //} while (opc != "0");

            var carros = new[] { "celta", "palio", "corsa", "up", "fusca", "renegate", "gol" };
            for(int indice = 0; indice< carros.Length; indice++)
            {
                Console.WriteLine(carros[indice]);
            }
        }
    }
}
