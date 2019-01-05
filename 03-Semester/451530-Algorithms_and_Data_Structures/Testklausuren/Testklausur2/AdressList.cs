using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Testklausur2
{
    public class AdressList {
        Hashtable<string, Zip> _table;
        string _filePath = "";

        public class Zip
        {
            public string PLZ { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string Number { get; set; }

            public override string ToString()
            {
                return $"{PLZ} {City} {Street} {Number}";
            }
        }

        public AdressList(string filePath)
        {
            _filePath = filePath;
            _table = new Hashtable<string, Zip>();
        }

        public Zip Search(string nachname)
        {
            if (nachname != "")
                if (_table.Contains(nachname))
                    return _table[nachname];
            return null;
        }


        public void Read()
        {
            using (var reader = new StreamReader(_filePath, Encoding.Default))
            {
                string line = reader.ReadLine();
                string[] columns = line.Split(';');
                if (columns.Length != 5)
                    throw new ArgumentException("Falsches Dateiformat");

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');

                    var nachname = values[4];

                    Zip zip = new Zip()
                    {
                        PLZ = values[0],
                        City = values[1],
                        Street = values[2],
                        Number = values[3]
                    };

                    _table.Add(nachname, zip);
                }
            }
        }
    }
}