using System;
using GSE;

namespace Bruchrechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Bruchrechnung - Brucheingabe", "Version 6");

            Console.WriteLine("Bruch b1 eingeben");
            Bruch b1 = Bruch.readBruch();
            Console.WriteLine("Bruch b2 eingeben");
            Bruch b2 = Bruch.readBruch();
            Console.WriteLine("b1 =      " + b1);
            Console.WriteLine("b2 =      " + b2);

            Bruch b3 = b1 * b2;
            Console.WriteLine("\nb1 * b2 = " + b3);
            Console.WriteLine("Dezimal = {0:f4}\n", (double)b3); // Konversionsoperator

            Bruch b4 = b1 + b2;
            Console.WriteLine("b1 + b2 = " + b4);
            Console.WriteLine("Dezimal = {0:f4}", (double)b4); // Konversionsoperator

            Helpers.zeigeProgrammende();
        }
    }
}
