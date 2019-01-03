namespace Laenge_einer_Zahl
{
    static public class Laenge_einer_Zahl
    {
        // nicht abweisende Schleife
        static public int RLANG_1(string zahl) {
            int i = 0;
            int anzahlZeichen = 0;
            string[] zahlenLaenge = new string[zahl.Length];

            while (i < zahl.Length)
            {
                zahlenLaenge[i] = zahl.Substring(i, 1);
                anzahlZeichen++;
                i++;
            }
            return anzahlZeichen;
        }

        // abweisende Schleife
        static public int WLANG_1(string zahl)
        {
            int i = 0;
            int anzahlZeichen = 0;
            string[] zahlenLaenge = new string[zahl.Length];

            do
            {
                zahlenLaenge[i] = zahl.Substring(i, 1);
                anzahlZeichen++;
                i++;
            } while (i < zahl.Length);
            return anzahlZeichen;
        }

    }
}
