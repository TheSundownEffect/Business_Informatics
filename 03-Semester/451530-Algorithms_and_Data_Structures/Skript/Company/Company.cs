using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Company : IComparable<Company>
    {
        public string Bezeichnung { get; set; }
        public string Branche { get; set; }
        public string Ort { get; set; }

        public int CompareTo(Company other)
        {
            return Bezeichnung.CompareTo(other.Bezeichnung);
        }

        public override string ToString()
        {
            return string.Format("Bezeichnung: {0}\tBranche: {1}\tOrt: {2}", Bezeichnung, Branche, Ort);
        }
    }

}
