using System;
using System.Linq;
using System.Text.RegularExpressions;

class LettersChangeNumbers
{
    static void Main(string[] args)
    {
        string[] words = Regex.Matches(Console.ReadLine(), @"[a-zA-Z]\d+[a-zA-Z]").Cast<Match>().Select(m => m.Value).ToArray();
        decimal sum = 0;
        for (int i = 0; i < words.Length; i++)
        {
            char firstLetter = words[i].First();
            char lastLetter = words[i].Last();
            decimal number = decimal.Parse(words[i].Substring(1, words[i].Length - 2));
            if (Char.IsUpper(firstLetter))
            {
                number = number / ((firstLetter - 'A') + 1);
            }
            else
            {
                number = number * ((firstLetter - 'a') + 1);
            }
            if (Char.IsUpper(lastLetter))
            {
                number = number - ((lastLetter - 'A') + 1);
            }
            else
            {
                number = number + ((lastLetter - 'a') + 1);
            }
            sum += number;
        }
        Console.WriteLine("{0:F2}", sum);
    }
}