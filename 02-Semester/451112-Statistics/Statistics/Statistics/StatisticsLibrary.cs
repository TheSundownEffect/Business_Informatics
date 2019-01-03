using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    class StatisticsLibrary
    {
        #region Mittelwerte
        public struct Mittelwerte
        {
            #region Median
            public static double Median(int[] data)
            {
                if (data.Length % 2 == 0)
                {
                    return (data[data.Length / 2 - 1] + data[(data.Length / 2)]) / 2;
                }
                else
                {
                    return data[((data.Length + 1) / 2) - 1];
                }
            }

            #endregion

            #region Modus
            public static double Modus(int[] data)
            {
                return data.Max();
            }
            #endregion

            #region (FEHLER) Geometrisches Mittel
            public static double geometrischesMittel(double[] data)
            {
                double temp = 0.00000;
                for (int i = 0; i < data.Length; i++)
                {
                    temp *= data[i];
                }
                return Math.Pow(temp, 1 / data.Length);
            }
            #endregion

            #region Harmonische Mittel
            public static double harmonischesMittel(double[] data)
            {
                throw new NotImplementedException();
            }
            #endregion

            #endregion

        }
    }
}
