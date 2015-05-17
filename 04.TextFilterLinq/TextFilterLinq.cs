using System;
using System.Linq;
using System.Text.RegularExpressions;

class TextFilter
{
    static void Main(string[] args)
    {
        string[] patternPieces = Regex.Split(Console.ReadLine(), @",\s*");
        string text = Console.ReadLine();
        text = patternPieces.Aggregate(text, (current, pattern) => Regex.Replace(current, pattern, new string('*', pattern.Length)));
        Console.WriteLine(text);
    }
}
