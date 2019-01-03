/* * * * * * *
 * Title:   Referenz- und Werttypen
 * Author:  Christian B.
 * Date:    01.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion
namespace Referenz__und_Werttypen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Werttyp
            int z1 = 0;
            change(z1);
            Console.WriteLine("Werttyp: " + z1);

            // Referenztyp
            z1 = 0;
            change(ref z1);
            Console.WriteLine("Referenztyp: " + z1);

            var zClass = new ZahlClass() { zahl1 = 0 };
            change(zClass);
            Console.WriteLine("Referenztyp (Klasse): " + zClass.zahl1);

            var zStruct = new ZahlStruct() { zahl1 = 0 };
            change(zStruct);
            Console.WriteLine("Werttyp (Struct): " + zStruct.zahl1);
        }

        private static void change(int zahl1)
        {
            zahl1 = 100;
        }

        private static void change(ref int zahl1)
        {
            zahl1 = 100;
        }

        static void change(ZahlClass zahl)
        {
            zahl.zahl1 = 100;
        }

        static void change(ZahlStruct zahl)
        {
            zahl.zahl1 = 100;
        }

        class ZahlClass
        {
            public int zahl1;
        }

        struct ZahlStruct
        {
            public int zahl1;
        }
    }
}
