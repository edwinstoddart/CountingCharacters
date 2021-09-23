using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Library
            Dictionary<string, int> CharacterCount = new Dictionary<string, int>();
            string Input;

            // Console Prompt; Ask the user for a string (without numeric characters)
            Console.WriteLine("Hello, please enter a series of alphabetic characters.\n" +
                "I'll tell you how many of each character you have entered.\n" +
                "Please exclude any non-alphabetic characters: ");
            while (true)
            {
                Input = Console.ReadLine();
                Input = Input.ToLower();
                if (Utility.CheckCharacters(Input))
                {
                    Console.WriteLine("I'm sorry, you've entered an invalid character. Please try again:");
                    continue;
                } else {
                    break;
                } // End: if()
            } // End: while()

            Utility.CountCharacters(Input, CharacterCount);
            Utility.PrintCount(CharacterCount);
        }
    }
}
