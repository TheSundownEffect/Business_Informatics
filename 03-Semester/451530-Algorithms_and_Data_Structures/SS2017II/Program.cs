using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Aufgabe 6: Schreiben Sie eine Konsolenanwendung, die Informationen zu Verkaufsstellen der DB aus der Datei "Verkaufsstellen.csv" einliest und nach den Verkaufsstellennummer (z.B. 500157) in einer Hashtable suchen lässt. Es sollen nur die Spalten Verkaufsstellennr., Name1, Straße, PLZ und Ort verarbeitet werden. (41P)

Erstellen Sie dazu eine Klasse VerkaufsstellenList, die die Methoden Search und Read implementiert.

Die Methode Read liest alle Verkaufsstellen aus der Textdatei ein. Der Dateiname wird der Methode als Zeichenkette übergeben.
Der Methode Search wird ein Verkaufsstellennummer (z.B. 500157) übergeben. Als Suchergebnis liefert sie eine Instanz der Klasse Verkaufsstellen mit den Spalten Verkaufsstellennr., Name1, Straße, PLZ und Ort.

Beispiel zur Verwendung:

Code: [Auswählen]

var list = new VerkaufsstellenList();

list.Read("Verkaufsstellen.csv");
int verkaufsstellennr = 500157;
Verkaufsstelle verkaufsstelle = list.Search (verkaufsstellennr);
Console.WriteLine(verkaufsstelle);

*/




namespace SS2017II
{
    class Program
    {
        static void Main(string[] args)
        {
            var verkaufsstellenList = new VerkaufsstellenList();
            verkaufsstellenList.Read(@"C:\GitHub\Business_Informatics\03-Semester\451530-Algorithms_and_Data_Structures\Skript\_Testdaten\Verkaufsstellen.csv");
            int verkaufsstellennr = 251444;
            Console.WriteLine(verkaufsstellenList.Search(verkaufsstellennr));
        }
    }
}
