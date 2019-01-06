using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace SS2017II
{
    public class VerkaufsstellenList
    {
        HashMap<int, VKStelle> _liste;

        public VerkaufsstellenList()
        {
            _liste = new HashMap<int, VKStelle>();
        }

        public class VKStelle
        {
            public int VKNummer { get; set; }
            public string Name { get; set; }
            public string Straße { get; set; }
            public string PLZ { get; set; }
            public string Ort { get; set; }

            public override string ToString()
            {
                return $"{VKNummer} {Name} {Straße} {PLZ} {Ort}";
            }
        }

        public VKStelle Search(int code)
        {
            int verkaufsstellennummer = 0;
            if (code != default(int))
            {
                verkaufsstellennummer = code;
            }
            if (_liste.Contains(verkaufsstellennummer))
            {
                return _liste[verkaufsstellennummer];
            }
            return null;
        }

        public void Read(string _companyListPath)
        {
            using (TextReader reader = File.OpenText(_companyListPath))
            {
                string line = reader.ReadLine();
                string[] spalten = line.Split(',');
                if (spalten.Length != 5)
                {
                    throw new ArgumentException("Wrong Data!");
                }
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    var VKStellennummer = int.Parse(values[0]);

                    VKStelle vkStelle = new VKStelle()
                    {
                        Name = values[1],
                        Straße = values[2],
                        PLZ = values[3],
                        Ort = values[4]
                    };

                    _liste.Add(VKStellennummer, vkStelle);
                }
            }
        }
    }
}
