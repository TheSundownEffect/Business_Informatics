using System;
using System.Collections.Generic;
using System.IO;

namespace Testklausur2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Stack<string> myStack = new Stack<string>() { "one", "two", "three" };

            var tree = new BinaryTree<string>();
            tree.Add("Flensburg");
            tree.Add("Suederstapel");
            tree.Add("Heide");
            tree.Add("Meyn");
            tree.Add("Witzwort");
            tree.Add("Dach");


            string filePath = @"C:\GitHub\Business_Informatics\03-Semester\451530-Algorithms_and_Data_Structures\Testklausuren\Testklausur2\Adresse.txt";
            var myAdressList = new AdressList(filePath);
            myAdressList.Read();

            myAdressList.Search("Bräunlich");

        }
    }
}
