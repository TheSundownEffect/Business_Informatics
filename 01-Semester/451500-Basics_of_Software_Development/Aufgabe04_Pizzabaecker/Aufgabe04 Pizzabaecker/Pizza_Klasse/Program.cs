using System;
using GSE;
namespace Pizza_Klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmidentifikation
            Helpers.zeigeTitel("Pizzabäcker (Klasse)", "Preiskalkulation einer Pizza");

            // Eingabeteil für Durchmesser
            Console.Write("Durchmesser der Pizza in cm (max. 255): ");
            byte durchmesser = Byte.Parse(Console.ReadLine());
                        
           // Berechnung des Preises mittels Klassenmethode 
            double preis = Pizza.berechnePreis(durchmesser);
            
            // Ausgabe des Preises
            Console.WriteLine("\nDie Pizza mit {0} cm Durchmesser kostet {1,0:n} EUR",
                durchmesser, preis);

            // Programmendemeldung
            Helpers.zeigeProgrammende();
        }
    }
}
