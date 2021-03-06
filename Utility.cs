using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacters
{
    class Utility
    {
        public static void CountCharacters(string Input, Dictionary<char, int> CharacterCount)
        {
            foreach (char c in Input.ToCharArray())
            {
                if (CharacterCount.ContainsKey(c))
                {
                    CharacterCount[c]++;
                } else {
                    CharacterCount.Add(c, 1);
                } // End: if()
            } // End: foreach()
        } // End: CountCharacters()

        public static void PrintCount(Dictionary<char, int> CharacterCount)
        {
            foreach (KeyValuePair<char, int> character in CharacterCount)
            {
                Console.WriteLine($"{character.Key}: {character.Value}");
            } // End foreach()
        } // End: PrintCount()

        public static bool CheckCharacters(string Input)
        {
            char[] AllowedChars = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'};
            if (Input.Length == 0) { return true; }
            foreach (char c in Input)
            {
                if (!AllowedChars.Contains(c))
                {
                    return true;
                } // End: if()
            } // End: foreach()
            return false;
        } // End: CheckCharacters()
    }
}
