using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanIst
{
    class PlanIst
    {
    static public double stringToDouble(String s)
        {
            return Convert.ToDouble(s);
        }

    static public double gesamtabweichung(Double planmenge, Double planpreis, Double istmenge, Double istpreis)
        {
            return ((planmenge * planpreis) - (istmenge * istpreis));
        }
    static public double preisabweichung(double planpreis, double istpreis, double istmenge) 
        {
            return ((planpreis - istpreis) * istmenge);
        }
    static public double mengenabweichung(double planmenge, double istmenge, double planpreis) 
        {
            return ((planmenge - istmenge) * planpreis);
        }
    }
}
