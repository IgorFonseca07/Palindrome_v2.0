using System;

namespace Palindrome_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            // Developed by Igor Oliveira Fonseca

            Console.Write("What's the sequence of characters (can be a word, number, phrase...): ");
            string sequenceCharacters = Console.ReadLine().ToUpper().Trim();

            int count = 0;
            for (int i = 0; i < (sequenceCharacters.Length / 2); i++)
            {
                if (sequenceCharacters[i] == sequenceCharacters[sequenceCharacters.Length - (i + 1)])
                {
                    count++;
                }                
            }
            if (count == (sequenceCharacters.Length / 2))
            {
                Console.WriteLine("It's Palindrome!");
            }
            else
            {
                Console.WriteLine("It's not Palindrome!");
            }

        }
    }
}
