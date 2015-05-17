using System;
using System.Linq;

class StringLength
{
    static void Main(string[] args)
    {
        string sentence = new string(Console.ReadLine().PadRight(20, '*').Take(20).ToArray());
        Console.WriteLine(sentence);
    }
}
