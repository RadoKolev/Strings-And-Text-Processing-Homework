using System;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Please enter your string:");
        string input = Console.ReadLine();

        if (input.Length >= 20)
        {
            Console.WriteLine("The result is: " + input.Substring(0, 20));
        }
        else
        {
            Console.WriteLine("The result is: " + input.PadRight(20, '*'));
        }

    }
}