using System;

namespace URI___1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int ano, mes, dias;
            ano = (valor / 365);
            valor -= ano * 365;
            mes = (valor / 30);
            valor -= mes * 30;
            dias = valor;
           
            Console.WriteLine(ano + " ano (s)");
            Console.WriteLine(mes + " mes (es)");
            Console.WriteLine(dias + " dias (s)");

        }
    }
}
