using GSE;
namespace Aufgabe01_Statisch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Die Erzeugung einer Instanz ist nun nicht mehr nötig,
            // da ausschließlich Klassenmethoden implementiert wurden.
            // Helpers helpers = new Helpers();
            // Aufruf aller Klassenmethoden
            Helpers.zeigeTitel();
            Helpers.zeigeProgrammende();
            Helpers.zeigeTitel("Methode mit Parameter");
            Helpers.zeigeProgrammende();
            Helpers.zeigeTitel("Test Helpers", "Methode mit zwei Parametern");
            Helpers.zeigeProgrammende();
        }
    }
}
