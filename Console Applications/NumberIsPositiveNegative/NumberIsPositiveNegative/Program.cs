using System;

namespace NumberIsPositiveNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1-Direktor");
            Console.WriteLine("2-Mellim");
            Console.WriteLine("3-Sagird");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Direktor ucun kecid etdiniz");
                    break;
                case 2:
                    Console.WriteLine("Mellim ucun kecid etdiniz");
                    break;
                case 3:
                    Console.WriteLine("Sagird ucun kecid etdiniz");
                    break;
                default:
                    Console.WriteLine("Bele bir secim yoxdur");
                    break;
            }

        }
    }
}
