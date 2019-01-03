/* * * * * * *
 * Title:   HashMap
 * Class:   ZipCodes.cs
 * Author:  Christian B.
 * Date:    02.01.2019
 * 
*/

#region Bibliothek von Alexandria
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace HashMap
{
    public class ZipCodes
    {
        string _pathToCsv;
        HashMap<int, Zip> _table;

        public ZipCodes(string pathToCsv)
        {
            _pathToCsv = pathToCsv;
            _table = new HashMap<int, Zip>();
        }

        public class Zip
        {
            //public int ZIPCode { get; set; }
            public string City { get; set; }
            public string State { get; set; }

            public override string ToString()
            {
                return $"" + /*{ZIPCode}*/ $"{ City} {State}";
            }
        }

        public void ReadData()
        {
            using (var reader = new StreamReader(_pathToCsv))
            {
                string line = reader.ReadLine();
                string[] columns = line.Split(';');
                if (columns.Length != 3)
                    throw new ArgumentException("Falsches Dateiformat");

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');

                    var ZIPCode = int.Parse(values[0]);

                    Zip zip = new Zip()
                    {
                        City = values[1],
                        State = values[2]
                    };

                    _table.Add(ZIPCode, zip);
                }
            }
        }
        public Zip Search(string code)
        {
            int zipCode = 0;
            if (code != "") {
                zipCode = int.Parse(code);
            }

            if (_table.Contains(zipCode))
                return _table[zipCode];
            return null;
        }
    }
}
