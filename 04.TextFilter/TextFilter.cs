using System;
using System.Text.RegularExpressions;

class TextFilter
{
    static void Main(string[] args)
    {
        string[] patternPieces = Regex.Split(Console.ReadLine(), @",\s*");
        string text = Console.ReadLine();
        //Resharper казва, че може да се замени с LINQ заявка, маркирам(където е подчертанo в зелено)и Alt + Enter-виж следващия проджект.
        foreach (var pattern in patternPieces)
        {
            text = Regex.Replace(text, pattern, new string('*', pattern.Length));
        }
        Console.WriteLine(text);
    }
}
