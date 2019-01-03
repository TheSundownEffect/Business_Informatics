using System;
using GSE;

namespace Pizza_Instanz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmidentifikation
            Helpers.zeigeTitel("Pizzabäcker (Instanz)", "Preiskalkulation einer Pizza");

            // Eingabeteil für Durchmesser
            Console.Write("Durchmesser der Pizza in cm (max. 255): ");
            byte durchmesser = Byte.Parse(Console.ReadLine());

            // Berechnung des Preises
            // Neue Pizza instanziieren, Referenzvariable gorgonzola
            Pizza gorgonzola = new Pizza();
            // öffentliche Instanzvariable Durchmesser setzen. Das ist
            // der Grund, warum diese (derzeit) öffentlich sein muss. gorgonzola.durchmesser = durchmesser;

            // Berechnung des Preises mit der Instanzmethode
            double preis = gorgonzola.berechnePreis();
            
            //Ausgabe des Preises 
            Console.WriteLine("Die Pizza mit {0} cm Durchmesser kostet {1,0:n} EUR",
                durchmesser, preis);

            // Programmendemeldung
            Helpers.zeigeProgrammende();
        }
    }
}
