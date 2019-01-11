using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountancy2
{
    class Program
    {
        static void Main(string[] args)
        {
            //AccountancyLibrary.Controlling

            #region Aufgabe 19
            // Aufgabe 19
            Console.WriteLine("Aufgabe 19");
            Console.WriteLine("a)");
            Console.WriteLine(AccountancyLibrary.KostenLeistungsRechnung.CostUnitAccounting.DivisionCalculation.TwoStage(450000 / 30000, (48000 + 28400) / 30000.0));
            Console.WriteLine("b)");
            Console.WriteLine(AccountancyLibrary.KostenLeistungsRechnung.CostUnitAccounting.DivisionCalculation.TwoStage(450000 / 30000, (48000 + 28400) / 25000.0));
            #endregion

            #region Aufgabe 20
            Console.WriteLine("Aufgabe 20");
            Console.WriteLine("a)");


            double Kverwaltung = 9200, Kvertrieb = 4600;

            double[] FertigungskostenDerKostenstellen = new double[] { 112000, 48000 };

            int[] bearbeiteteMenge = new int[] { 2000, 1600 };


            int Absatzmenge = 1400;

            Console.WriteLine(AccountancyLibrary.KostenLeistungsRechnung.CostUnitAccounting.DivisionCalculation.MultiLevel(FertigungskostenDerKostenstellen, bearbeiteteMenge, Kverwaltung + Kvertrieb, Absatzmenge));

            Console.WriteLine("b)");
            Console.WriteLine(FertigungskostenDerKostenstellen[0] / bearbeiteteMenge[0]);

            Console.WriteLine("c)");
            double sum = 0;
            for (int i = 0; i < FertigungskostenDerKostenstellen.Length; i++)
            {
                sum += FertigungskostenDerKostenstellen[i] / bearbeiteteMenge[i];
            }

            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
