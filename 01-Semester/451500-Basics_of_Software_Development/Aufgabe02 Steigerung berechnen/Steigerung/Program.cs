using System;
using GSE;  // Namespace mit der Klasse Helpers
namespace Steigerung
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.zeigeTitel("Jährliche Umsatzsteigerung berechnen",
                "Version Literale");

            Console.WriteLine("Umsatz im Jahr 2010    : " + 1234567d);
            Console.WriteLine("Umsatz im Jahr 2016    : " + 2345678d);

            // Die nachfolgende Verwendung des Zeichens d als Kennzeichnung für ein
            // Literal vom Typ double ist zwingend erforderlich: Wird dies nicht
            // angefügt, wird die Ganzzahldivision 1234567 / 2345678 durchgeführt,
            // die als Ergebnis den Wert 1 hat. D.h., der Gesamtanstieg wäre
            // 1 * 100 - 100, also 0 Prozent. Erst durch die Kennzeichnung der
            // Literale als double durch das Suffix d ergibt sich hier ein Wert
            // von 1,113 und somit ein Gesamtanstieg von 1,113 * 100 - 100, d.h.
            // 11,3... %. Alternativ kann das Literal auch durch 1234567.0 als
            // double-Wert gekennzeichnet werden.
            
            Console.WriteLine("Gesamtanstieg 2010-2016: " + 
                (2345678d / 1234567d * 100 - 100) + " %");
            
            // Es gilt: mittl. jährliche Steigerung = n. Wurzel aus Gesamtanstieg
            //          mit n = Jahre (hier 6 Jahre)
            // allg.  : n.te Wurzel aus x entspricht x hoch (1/n)
            //          Math.Pow(x, 1/n)
            Console.WriteLine("jhrl. Anstieg 2010-2016: " +
                ((Math.Pow((2345678d / 1234567d), (1d / (2016 - 2010))) - 1)  * 100 + " %"));

            Helpers.zeigeProgrammende();
        }
    }
}
