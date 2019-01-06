using System;
using System.IO;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToFile = args[0];
            string text = File.ReadAllText(pathToFile);

            var spellchecker = new SpellChecker();

            foreach (Word word in spellchecker.CheckText(text))
            {
                if (!word.IsCorrect)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                Console.Write(word.SingleWord + " ");
            }
        }
    }

}
