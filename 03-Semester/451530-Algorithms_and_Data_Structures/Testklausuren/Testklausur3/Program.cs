using System;

namespace KlausurAuD
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedArrayList<int> liste = new SortedArrayList<int>();
            liste.Add(1);
            liste.Add(2);
            liste.Add(4);
            liste.Add(10);
            liste.Add(15);

            foreach (int number in liste.GreaterThan(4))
            {
                Console.WriteLine(number);
            }
        }
    }
}
