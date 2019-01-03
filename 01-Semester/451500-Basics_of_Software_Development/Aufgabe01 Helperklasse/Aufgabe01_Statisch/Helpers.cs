using System;

// Lösung Aufgabe 01 unter Verwendung von Klassenmethoden

namespace GSE 
{
    class Helpers
    {
        // zeigeTitel(): Löscht die Console und schreibt den Titel „Konsolanwendung © Ihr Name“, 
        // gefolgt von zwei Zeilenumbrüchen auf die Konsole. Zusätzlich wird der Titel in der 
        // Überschrift des Konsolfensters angezeigt

        public static void zeigeTitel()
        {
            // Konsolfenster löschen
            //Console.Clear();
            // Eigenschaft title setzen
            //Console.Title = "Konsolanwendung © THM";
            // Eigenschaft Title als Zeile in Konsole ausgeben gefolgt von zwei Leerzeilen
            //Console.WriteLine(Console.Title + "\n\n");
            // bzw. viel einfacher wie folgt:
            zeigeTitel("Konsolanwendung © THM");
        }

        // zeigeTitel(string titel): implementiert die gleiche Funktionalität wie 1., 
        // nimmt aber einen Parameter für den Titel an.

        public static void zeigeTitel(string titel)
        {
            // Konsolfenster löschen
            //Console.Clear();
            // Eigenschaft title setzen
            //Console.Title = titel;
            // Eigenschaft Title als Zeile in Konsole ausgeben gefolgt von zwei Leerzeilen
            //Console.WriteLine(Console.Title + "\n\n");
            // bzw. viel einfacher wie folgt:
            zeigeTitel(titel, titel);
        }

        // zeigeTitel(string titel, string ueberschrift): wie 2., verwendet aber für 
        // den Titel des Konsolenfensters den als titel und für die Überschrift in 
        // der Konsole den als ueberschrift übergebenen Parameter.

        public static void zeigeTitel(string titel, string ueberschrift)
        {
            // Konsolfenster löschen
            Console.Clear();
            // Eigenschaft title setzen
            Console.Title = titel;
            // ueberschrift als Zeile in Konsole ausgeben gefolgt von zwei Leerzeilen
            Console.WriteLine(ueberschrift + "\n\n");
        }

        // zeigeProgrammende(): gibt eine Leerzeile und dann die Zeichenfolge 
        // „Programmende mit <RETURN>-Taste…“ auf dem Bildschirm aus und wartet 
        // auf die Betätigung der <RETURN>-Taste

        public static void zeigeProgrammende()
        {
            Console.Write("\nProgrammende mit <RETURN>-Taste. . .");
            Console.ReadLine();
        }
    }
}
