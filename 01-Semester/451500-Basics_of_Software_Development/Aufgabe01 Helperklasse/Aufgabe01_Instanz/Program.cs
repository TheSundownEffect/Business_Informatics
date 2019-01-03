using GSE;
namespace Aufgabe01_Instanz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erzeugen einer Instanz der Klasse Helpers mittels 
            // new-Operator (= Konstruktoraufruf) und Speicherung
            // der Adresse der Instanz in der Referenzvariablen helpers
            Helpers helpers = new Helpers();
            // Aufruf aller Instanzmethoden über die Instanz helpers
            helpers.zeigeTitel();
            helpers.zeigeProgrammende();
            helpers.zeigeTitel("Aufgabe 01 - Helperklasse");
            helpers.zeigeProgrammende();
            helpers.zeigeTitel("Aufgabe 01", "Helperklasse");
            helpers.zeigeProgrammende();
        }
    }
}
