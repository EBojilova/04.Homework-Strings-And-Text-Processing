using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Palindromes
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = Regex.Matches(text, @"\b[A-Za-z]+\b").Cast<Match>().Select(m => m.Value).ToArray();
            var palindromes =new SortedSet<string>();
            foreach (var word in words)
            {
                char[] reversed = word.ToCharArray();
                Array.Reverse(reversed);
                if (word==new string(reversed))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",palindromes));
        }
    }
