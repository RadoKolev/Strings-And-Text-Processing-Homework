using System;
using System.Linq;

class ReversString
{
    private static void Main()
    {
        Console.Write("Please enter your string: ");
        var input = Console.ReadLine().ToCharArray();
        Array.Reverse(input);
        string reversed = new string(input);
        Console.WriteLine("Reversed string: " + reversed);
    }
}