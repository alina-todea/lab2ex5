using System;

namespace Lab2ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Scrieti o functie care afisa piramida numerelor pare, intre 2 si n, n fiind citit de la tastatura
             */
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());

            Piramida(n);
        }
        static void Piramida(int n)
        {
            for (int i = 2; i <=n; i+=2)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }


        }
    }
}
