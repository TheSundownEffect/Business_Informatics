using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    public class SpellChecker
    {
        Dictionary dictionary = new Dictionary();
        public IEnumerable<Word> CheckText(string text)
        {
            string[] words = text.Split(' ');

            foreach (string w in words)
            {
                Word word = new Word();
                word.SingleWord = w;
                word.IsCorrect = dictionary.Contains(w.ToLower());

                yield return word;
            }
        }
    }
}