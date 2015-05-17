using System;
using System.Linq;

class ReverseString
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string reverced = new string(word.Reverse().ToArray());
        Console.WriteLine(reverced);
    }
}
