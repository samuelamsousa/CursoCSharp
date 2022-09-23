using System;

namespace URI___1021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            string R1C1parametro = Console.ReadLine();
            string[] R101parametro = R1C1parametro.Split(' ');
            int R1C1 = int.Parse(R101parametro[2]);
            

            string R1C2parametro = Console.ReadLine();
            string[] RT102paremetro = R1C2parametro.Split(' ');
            int R1C2 = int.Parse(RT102paremetro[2]);
            

            string R2C1parametro = Console.ReadLine();
            string[] RT201parametro = R2C1parametro.Split(' ');
            int R2C1 = int.Parse(RT201parametro[2]);
            

            string R2C2parametro = Console.ReadLine();
            string[] RT202parametro = R2C2parametro.Split(' ');
            int R2C2 = int.Parse(RT202parametro[2]);
            

            string R2C3parametro = Console.ReadLine();
            string[] RT203parametro = R2C3parametro.Split(' ');
            int R2C3 = int.Parse(RT203parametro[2]);
            

            string R3C1parametro = Console.ReadLine();
            string[] RT301parametro = R3C1parametro.Split(' ');
            int R3C1 = int.Parse(RT301parametro[2]);
           

            string R3C2parametro = Console.ReadLine();
            string[] RT302parametro = R3C2parametro.Split(' ');
            int R3C2 = int.Parse(RT302parametro[2]);
            

            string R4C1parametro = Console.ReadLine();
            string[] RT401parametro = R4C1parametro.Split(' ');
            int R4C1 = int.Parse(RT401parametro[2]);
            

            string R4C2parametro = Console.ReadLine();
            string[] RT402parametro = R4C2parametro.Split(' ');
            int R4C2 = int.Parse(RT402parametro[2]);
            

            string R5C1parametro = Console.ReadLine();
            string[] RT501parametro = R5C1parametro.Split(' ');
            int R5C1 = int.Parse(RT501parametro[2]);
            

            string R5C2parametro = Console.ReadLine();
            string[] RT502parametro = R5C2parametro.Split(' ');
            int R5C2 = int.Parse(RT502parametro[2]);
            

            string R6C1parametro = Console.ReadLine();
            string[] RT601parametro = R6C1parametro.Split(' ');
            int R6C1 = int.Parse(RT601parametro[2]);

            int total = 0;
            
         
            if (R1C1 <= R1C2)
            {
                total += R1C1;
            }
            else
            {
                total += R1C2;
            }
            int[] tes = { R2C1, R2C2, R2C3 };
            Array.Sort(tes);
            int menor = tes.GetLowerBound(0);

            /*if (R2C1 <= && R2C2 <= && R2C3)
            {
                total += R2C1;
            }*/

           if (R3C1 <= R3C2)
            {
                total += R3C1;
            }
            else
            {
                total += R3C2;
            }
            if (R4C1 <= R4C2)
            {
                total += R4C1;
            }
            else
            {
                total += R4C2;
            }

            if (R5C1 <= R5C2)
            {
                total += R5C1;
            }
            else
            {
                total += R5C2;
            }
            
            
            Console.WriteLine(total + R6C1 + menor);
        }
    }

}
