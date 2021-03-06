﻿using System;

namespace GSE 
{
    class Helpers  // hier mit statischen Membern
    {
        // zeigeTitel(): Löscht die Console und schreibt den Titel „Konsolanwendung © Ihr Name“, 
        // gefolgt von zwei Zeilenumbrüchen auf die Konsole. Zusätzlich wird der Titel in der 
        // Überschrift des Konsolfensters angezeigt

        public static void zeigeTitel()
        {
            //Console.Clear();
            //Console.Title = "Konsolanwendung © THM";
            //Console.WriteLine(Console.Title + "\n\n");
            zeigeTitel("Konsolanwendung © THM");
        }

        // zeigeTitel(string titel): implementiert die gleiche Funktionalität wie 1., 
        // nimmt aber einen Parameter für den Titel an.

        public static void zeigeTitel(string titel)
        {
            //Console.Clear();
            //Console.Title = titel;
            //Console.WriteLine(Console.Title + "\n\n");
            zeigeTitel(titel, titel);
        }

        // zeigeTitel(string titel, string ueberschrift): wie 2., verwendet aber für 
        // den Titel des Konsolenfensters den als titel und für die Überschrift in 
        // der Konsole den als ueberschrift übergebenen Parameter.

        public static void zeigeTitel(string titel, string ueberschrift)
        {
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.Title = titel;
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
