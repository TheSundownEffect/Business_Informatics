/* * * * * * *
 * Title:   Aufgaben 1 bis 2
 * Class:   Program.cs
 * Author:  Christian B.
 * Date:    05.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion


/* Aufgabe 1:
 * Lesen Sie auf wikipedia.de über die Begriffe Datentyp,Datenstruktur, Klasse und Objekt.
 * Diskutieren Sie mit Ihrem Nachbarn und grenzen Sie die Begriffe voneinander ab!
 * Wodurch unterscheiden sich die Begriffe?
 */

    #region Lösung: Aufgabe 1
    // Datentyp:        https://de.wikipedia.org/wiki/Datentyp
    // Datenstruktur:   https://de.wikipedia.org/wiki/Datenstruktur
    // Objekttyp:       https://de.wikipedia.org/wiki/Klasse_(Objektorientierung)
    // Objekt:          https://de.wikipedia.org/wiki/Objekt_(Programmierung)

    /* Datentyp:
     *  Beschreibung der in ihm gespeicherten Werte und darauf auszuführenden Methoden/Operationen  */
    /* Datenstruktur:
     *  Datentyp, i.e.S. allgemein einsetzbare Datentypen wie Listen-, Baumstrukturen usw.          */

    #endregion


/* Aufgabe 2:
 * Erstellen Sie ein Projekt in Visual Studio 2017für das Beispiel aus den Folien 10, 11 und 12.
 * Sehen Sie sich im Debugger die Veränderungen der Übergabeparameter im Arbeitsspeicher an!
 */



namespace Aufgaben_1_bis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lösung: Aufgabe 2
            // Werttyp
            int z1 = 0;
            change(z1);
            Console.WriteLine("Werttyp: " + z1);

            // Referenztyp
            z1 = 0;
            change(ref z1);
            Console.WriteLine("Referenztyp: " + z1);

            var zClass = new ZahlClass() { zahl1 = 0 };
            change(zClass);
            Console.WriteLine("Referenztyp (Klasse): " + zClass.zahl1);

            var zStruct = new ZahlStruct() { zahl1 = 0 };
            change(zStruct);
            Console.WriteLine("Werttyp (Struct): " + zStruct.zahl1);
        }

        private static void change(int zahl1)
        {
            zahl1 = 100;
        }

        private static void change(ref int zahl1)
        {
            zahl1 = 100;
        }

        static void change(ZahlClass zahl)
        {
            zahl.zahl1 = 100;
        }

        static void change(ZahlStruct zahl)
        {
            zahl.zahl1 = 100;
        }

        class ZahlClass
        {
            public int zahl1;
        }

        struct ZahlStruct
        {
            public int zahl1;
        }

        #endregion
    }
}