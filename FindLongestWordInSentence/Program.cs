using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLongestWordInSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence to find the longest word in it:");
            string sentence = Console.ReadLine();
            string longestWord = FindLongestWord(sentence);
            Console.WriteLine($"The longest word in the sentence is: {longestWord}");
            Console.ReadKey();
        }

        static string FindLongestWord(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return string.Empty;

            string[] words = sentence.Split(' ');
            string longestWord = words.FirstOrDefault();
            foreach (var word in words)
            {
                if (longestWord.Length < word.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }
    }
}

