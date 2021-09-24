using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Library
            Dictionary<char, int> CharacterCount = new Dictionary<char, int>();
            int Choice;
            string Input;

            // Console Prompt; Ask the user for a string (without numeric characters)
            Console.WriteLine("Please enter a series of alphabetic characters.\n" +
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
                }
                else
                {
                    break;
                } // End: if()
            } // End: while()

            CharacterCount.Clear();
            Utility.CountCharacters(Input, CharacterCount);
            Utility.PrintCount(CharacterCount);

            /* -------------------------------------------------- */

            // Have the User select a file foz
            Console.WriteLine("Please Select a File:\n" +
                "0: Only Letters\n" +
                "1: Only Numbers\n" +
                "2: Letters & Numbers");

            while (true)
            {
                while (true)
                {
                    Input = Console.ReadLine();
                    if (int.TryParse(Input, out int result))
                    {
                        Choice = int.Parse(Input);
                        if (Choice == 0 || Choice == 1 || Choice == 2)
                        {
                            break;
                        } // End: if()
                    } // End: if()
                    Console.WriteLine("I'm sorry, that isn't one of the options. Please pick:\n" +
                        "0: Only Letters\n" +
                        "1: Only Numbers\n" +
                        "2: Letters & Numbers");
                } // End while()

                switch (Choice)
                {
                    case 0: Input = System.IO.File.ReadAllText("../../../OnlyLetters.txt"); break;
                    case 1: Input = System.IO.File.ReadAllText("../../../OnlyNumbers.txt"); break;
                    case 2: Input = System.IO.File.ReadAllText("../../../Letters&Numbers.txt"); break;
                }

                Console.WriteLine($"Contents of File: {Input}");
                Input = Input.ToLower();
                if (Utility.CheckCharacters(Input))
                {
                    Console.WriteLine("I'm sorry, that file contains non-alphabetic characters.\n" +
                        "Please pick again:\n" +
                        "0: Only Letters\n" +
                        "1: Only Numbers\n" +
                        "2: Letters & Numbers");
                    continue;
                }
                else
                {
                    break;
                } // End: if()
            } // End: while()

            CharacterCount.Clear();
            Utility.CountCharacters(Input, CharacterCount);
            Utility.PrintCount(CharacterCount);
        }
    }
}
