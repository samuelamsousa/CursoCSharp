using System;

namespace URI___1019
{
    class Program
    {
        static void Main(string[] args)
        {

            int tempo = int.Parse(Console.ReadLine());
            int H, M, S;
            H = (tempo / 3600);
            Console.WriteLine(tempo -= H * 3600);
            M = (tempo / 60);
            Console.WriteLine(tempo -= M * 60);
            S = tempo;

            Console.WriteLine(H + ":" + M + ":" + S);
        }
    }
}
