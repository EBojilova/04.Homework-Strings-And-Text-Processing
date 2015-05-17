using System;

namespace _03.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(word, i)) != -1)
            {
                i ++;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
