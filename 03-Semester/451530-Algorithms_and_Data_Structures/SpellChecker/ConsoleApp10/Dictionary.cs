using System.IO;

namespace ConsoleApp10
{
    public class Dictionary
    {
        LinkedList words = new LinkedList();

        StreamReader file = new StreamReader("german.dic", System.Text.Encoding.Default);

        public Dictionary()
        {
            while (file.Peek() >= 0)
            {
                words.Add(file.ReadLine().ToLower());
            }
            System.Console.WriteLine(words.Count);
        }

        public bool Contains(string word)
        {
            return words.Contains(word);
        }
    }
}