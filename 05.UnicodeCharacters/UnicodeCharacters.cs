using System;

internal class UnicodeCharacters
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();
        foreach (char letter in text)
        {
            Console.Write(string.Format(@"\u{0:x4}", (int)letter));
        }
        Console.WriteLine();
    }
}
