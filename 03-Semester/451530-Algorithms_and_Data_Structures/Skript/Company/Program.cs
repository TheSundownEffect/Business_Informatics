using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            // CSV einlesen
            var companies = new Companies();

            while (true)
            {
                Console.Write("Unternehmensbezeichnung eingeben: ");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;

                Company company = companies.Search(name);

                if (company == null)
                    Console.WriteLine("Unternehmen nicht gefunden!");
                else
                    Console.WriteLine(company + "\n");
            }
        }
    }
}
