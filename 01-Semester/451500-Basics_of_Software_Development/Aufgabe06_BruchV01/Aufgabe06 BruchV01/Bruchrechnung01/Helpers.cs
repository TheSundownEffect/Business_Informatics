using System;
/* 
 * Klasse           Helpers
 * Namespace        GSE
 * Veranstaltung    GSE (WIBSC)
 * Art              Übungsaufgabe 3 inkl. Ergänzungen
 * Kontext          Überladene Klassenmethoden mit Returnwert
 * Autor            Prof. Thomas Müller
*/
namespace GSE
{
    class Helpers
    {
        #region Titel und Ende
        // Aufgabe 2: mehrfach überladene Klassenmethode zeigeTitel()
        // Version 1: ohne Parameter
        //            Löscht Konsole, setzt Titel der Konsole mit einem 
        //            Standarddtext und gibt den Konsoltitel als 1. Zeile 
        //            auf der Konsole, gefolgt von einer Leerzeile, aus.
        //            Diese Klassenmethode ruft unten stehende Version 
        //            mit einem Parameter auf, anstatt die Anweisungen
        //            von unten zu wiederholen.
        public static void zeigeTitel()
        {
            zeigeTitel("Konsolanwendung (c) THM");
        }

        // Version 2: 1 Formalparameter vom Typ string
        //            Löscht Konsole, setzt Titel der Konsole mit dem
        //            übergebenen Parameter titel und gibt den Parameter 
        //            als 1. Zeile auf der Konsole, gefolgt von einer 
        //            Leerzeile, aus.
        //            Diese Klassenmethode ruft unten stehende Version 
        //            mit zwei Parametern auf, anstatt die Anweisungen
        //            von unten zu wiederholen.

        public static void zeigeTitel(string titel)
        {
            zeigeTitel(titel, titel);
        }

        // Version 3: 2 Formalparameter vom Typ string
        //            Löscht Konsole, setzt Titel der Konsole mit dem
        //            übergebenen Parameter titel und gibt den Parameter 
        //            ueberschrift als 1. Zeile auf der Konsole, gefolgt 
        //            von einer Leerzeile, aus.
        // NEU        Ergänzt durch eine Unterstreichung (for-Schleife)
        public static void zeigeTitel(string titel, string ueberschrift)
        {
            Console.Title = titel;
            Console.Clear();
            Console.WriteLine(ueberschrift);
            for (int i = 0; i < ueberschrift.Length; i++)
                Console.Write('~');
            Console.WriteLine("\n");
        }

        // Aufgabe 2: Klassenmethode zeigeProgrammende()
        //            gibt nach einer Leerzeile den Text Programmende mit 
        //            <RETURN<-Taste... aus und wartet auf die Benutzer-
        //            eingabe von <RETURN>
        public static void zeigeProgrammende()
        {
            Console.Write("\nProgrammende mit <RETURN>-Taste...");
            Console.ReadLine();
        }
        #endregion
       
        #region Wurzelziehen
            // Aufgabe 3: Methode nteWurzel
        //            zieht die n-te Wurzel aus dem Radikanten und
        //            liefert das Ergebnis als double-Werte zurück
        public static double nteWurzel(double n, double radikant)
        {
            // Da der Formalparameter n als double-Wert übergeben wird,
            // liefert der Ausdruck 1 / n ebenfalls einen double-Wert.
            return Math.Pow(radikant,  1 /  n);
        }

        // Aufgabe 3: Überladene Methode nteWurzel mit einem weiteren
        //            Formalparameter für das Runden des Ergebnisses
        //            auf nachkomma-Stellen.
        public static double nteWurzel(double n, double radikant, int nachkommaStellen)
        {
            // Dazu wird selbstverständlich die obige Methode wiederverwendet.
            return Math.Round(nteWurzel(n, radikant), nachkommaStellen);
        }
        #endregion
    }
}
