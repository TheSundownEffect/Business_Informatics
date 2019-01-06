using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Companies
    {
        BinaryTree<Company> companies = new BinaryTree<Company>();

        public Companies()
        {
            string path = @"C:\GitHub\Business_Informatics\03-Semester\451530-Algorithms_and_Data_Structures\Skript\_Testdaten\unternehmen.csv";

            using (TextReader reader = File.OpenText(path))
            {
                // Spaltenüberschriften auslesen
                string[] tokens = reader.ReadLine().Split(';');
                if (tokens.Length != 3)
                    throw new ArgumentException("More than 3 columns in company file");

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    tokens = line.Split(new char[] { ';' });

                    companies.Add(new Company()
                    {
                        Bezeichnung = tokens[0],
                        Branche = tokens[1],
                        Ort = tokens[2]
                    });
                }
            }
        }

        public Company Search(string bezeichnung)
        {
            return companies.Search(new Company() { Bezeichnung = bezeichnung });
        }
    }
}