using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Please enter your text:");
        string text = Console.ReadLine();

        Console.WriteLine("The C# Unicode character literals for your text are:");
        foreach (var letter in text)
        {
            Console.Write("\\u{0:x4}", ((int)letter));
        }
        Console.WriteLine();
    }
}