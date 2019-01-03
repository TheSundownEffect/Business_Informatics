using System;

/* 
 * Programm         pizza_Bad.cproj
 * Projekt          pizze.sln
 * Veranstaltung    GSE
 * Art              Übungsaufgabe
 * Kontext          Sprachelemente
 * Autor            Prof. Thomas Müller
 * Hinweis          Die SCHLECHTESTE Variante des Pizzabäckers
*/

namespace Pizza_Bad
{
    class Program
    {
        static void Main(string[] args)
        {
            byte durchmesser;
            Console.Write("Durchmesser der Pizza in cm: ");
            Console.WriteLine("\nDie Pizza mit " + 
                (durchmesser = Convert.ToByte(Console.ReadLine())) 
                + " cm Durchmesser kostet " 
                + Math.Round((Math.Pow(durchmesser, 2) * Math.PI / 4 * 0.01 + 2) * 1.5, 2) 
                + " EUR\n");
        }
    }
}
