using System;
using System.Collections.Generic;
using System.Runtime.DesignerServices;

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Please enter your text:");
        string[] inputText = Console.ReadLine().Split(new char[] { ',', ':', ';', ' ', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();

        Console.WriteLine();
        Console.WriteLine("Palindromes in your text:");
        for (int i = 0; i < inputText.Length; i++)
        {
            string reverse = Reverse(inputText[i]);
            if (inputText[i] == reverse)
            {
                palindromes.Add(inputText[i]);
            }
        }
        palindromes.Sort();
        Console.WriteLine(string.Join(", ", palindromes));
    }

    static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}