using System;
using System.Linq;

namespace P08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            decimal sum = 0;

            foreach (string word in words)
            {
                sum += CalculateSingleWordSum(word);
            }

            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateSingleWordSum(string word)
        {
            decimal sum = 0;

            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int num = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPos = GetAlphabeticalPositionOfCharacter(firstLetter);
            int lastLetterPos = GetAlphabeticalPositionOfCharacter(lastLetter);

            if (Char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPos;
            }
            else if (Char.IsLower(firstLetter))
            {
                sum = (decimal)num * firstLetterPos;
            }

            if (Char.IsUpper(lastLetter))
            {
                sum -= lastLetterPos;
            }
            else if (char.IsLower(lastLetter)) 
            {
                sum += lastLetterPos;
            }

            return sum;
        }

        static int GetAlphabeticalPositionOfCharacter(char ch)
        {
            if (!Char.IsLetter(ch))
            {
                return -1;
            }

            char chCI = Char.ToLowerInvariant(ch);

            return (int)chCI - 96;
        }
    }
}
