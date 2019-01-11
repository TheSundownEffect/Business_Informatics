using System;

namespace Accountancy2
{
    public static class AccountancyLibrary
    {
        public class Controlling
        {

        }


        public class KostenLeistungsRechnung
        {
            public static double LiquideMittel(double Kasse, double Sichtguthaben)
            {
                return Kasse + Sichtguthaben;
            }


            static class Depreciations
            {
                public static double Linear(double Anschaffungskosten, UInt16 Nutzungsdauer)
                {
                    return Anschaffungskosten / Nutzungsdauer;
                }

                public static double arithmeticDegressiv(double Anschaffungskosten, UInt16 Nutzungsdauer, int Zeitraum)
                {
                    double Degressionsbetrag = (2 * Anschaffungskosten) / (Nutzungsdauer * (Nutzungsdauer + 1));
                    return Degressionsbetrag * (Nutzungsdauer + 1 - Zeitraum);
                }

                public static double geometricDegressiv(double Restbuchwert, float Prozentsatz)
                {
                    return Restbuchwert * Prozentsatz;
                }

                public static double Variabel(double Anschaffungskosten, int gesamterLeistungsvorratBetriebsmittel, double LeistungsentnahmeInDerPeriodeT)
                {
                    return (Anschaffungskosten / gesamterLeistungsvorratBetriebsmittel) * LeistungsentnahmeInDerPeriodeT;
                }
            }

            static class Interests
            {
                public static double kalkulatorischeZinsen(double betriebsnotwendigesKapital, float Zinssatz)
                {
                    return betriebsnotwendigesKapital * Zinssatz;
                }
                public static double betriebsnotwendigesKapital(double Anlagevermoegen, double Umlaufvermoegen, int nichtBetriebsnotwendigesVermoegen)
                {
                    return Anlagevermoegen + Umlaufvermoegen - nichtBetriebsnotwendigesVermoegen;
                }



            }

            static class ventureReturns
            {
                public static double VentureReturns(double lfdBezugsgröße, double Wagnissatz)
                {
                    return lfdBezugsgröße * Wagnissatz;
                }

                public static double Wagnissatz(double eingetreteneWagnisverluste, double sinnvolleBezugsgroeße)
                {
                    return eingetreteneWagnisverluste / sinnvolleBezugsgroeße;
                }
            }

            static class InHouseActivityAllocation
            {

            }

            public static class CostUnitAccounting
            {
                public static class DivisionCalculation
                {
                    public static double SingleStage(double Gesamtkosten, int Produktionsmenge)
                    {
                        return Gesamtkosten / Produktionsmenge;
                    }

                    public static double TwoStage(double Herstellkosten, int Produktionsmenge, double VerwaltungsVertriebskosten, int Absatzmenge)
                    {
                        return (Herstellkosten / Produktionsmenge) + (VerwaltungsVertriebskosten / Absatzmenge);
                    }

                    public static double TwoStage(double HerstellkostenProStueck, double VerwaltungsVertriebskostenProStueck)
                    {
                        return HerstellkostenProStueck + VerwaltungsVertriebskostenProStueck;
                    }

                    public static double MultiLevel(double[] FertigungskostenDerKostenstelle, int[] bearbeiteteMengeDerKostenstelle, double VerwaltungsVertriebskosten, int Absatzmenge)
                    {
                        double sum = 0.00;

                        for (int i = 0; i < FertigungskostenDerKostenstelle.Length; i++)
                        {
                            sum += (FertigungskostenDerKostenstelle[i] / bearbeiteteMengeDerKostenstelle[i]);
                        }

                        return sum + (VerwaltungsVertriebskosten / Absatzmenge);
                    }

                    public static double MultiLevel(double Materialkosten, double[] FertigungskostenDerKostenstelle, int[] bearbeiteteMengeDerKostenstelle, double VerwaltungsVertriebskosten, int Absatzmenge)
                    {
                        double sum = 0.00;

                        for (int i = 0; i < FertigungskostenDerKostenstelle.Length; i++)
                        {
                            sum += (FertigungskostenDerKostenstelle[i] / bearbeiteteMengeDerKostenstelle[i]);
                        }

                        return Materialkosten + sum + (VerwaltungsVertriebskosten / Absatzmenge);
                    }
                }

                static class EquivalenceNumbersCalculation
                {
                    public static double EquivalenceNumber(double KostenDesProduktes, double KostenDesEinheitsproduktes)
                    {
                        return KostenDesProduktes / KostenDesEinheitsproduktes;
                    }

                    public static double SingleStage(int[] ProduzierteMenge, float[] Aequivalenzziffer, double Gesamtkosten)
                    {
                        double sum = 0.0;
                        for (int i = 0; i < ProduzierteMenge.Length; i++)
                        {
                            sum += ProduzierteMenge[i] * Aequivalenzziffer[i];
                        }

                        return Gesamtkosten / sum;
                    }

                }

                public static class OverheadCalculation
                {

                }

                public static class DomeCalculation
                {
                    public static double ResidualMethod() { 
                        return default(double);
                    }
                    public static double DistributionMethod()
                    {
                        return default(double);
                    }
                }
            }


            public static class PeriodCosting
            {
                public static void ComprehensiveIncome()
                {

                }


                public static class BreakevenAnalysis {
                    public static void SingleStage()
                    {

                    }

                    public static void MultiLevel()
                    {

                    }
                }
            }
        }
    }
}