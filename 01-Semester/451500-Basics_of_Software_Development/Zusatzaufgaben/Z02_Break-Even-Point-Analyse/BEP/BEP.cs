using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEP
{
    class BEP
    {
        static public int mindestabsatzmenge(double fixkosten, double varKosten, double preis) 
        {
            return Convert.ToInt32(Math.Ceiling(fixkosten / (preis - varKosten)));              // Math.Ceiling = in jedem Fall aufrunden.
        }
    }
}
