using System;

namespace Ex._12___Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int t = 0; t < 10; t++)
            {
                int nume;
                Console.WriteLine("Digite 1 para numeros pares");
                Console.WriteLine("Digite 2 para numeros Impares");
                nume = int.Parse(Console.ReadLine());
                Console.Clear();

                int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                for (int n = nume; n < numeros.Length; n += 2)
                {
                    Console.WriteLine(numeros[n]);
                }
                
            }
            
        }
    }
}
