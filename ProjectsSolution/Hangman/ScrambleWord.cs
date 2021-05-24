using System;
namespace Hangman
{
    public class ScrambleWord
    {

        private static readonly Random RandomNumberGenerator = new Random();

        public static string GetScrambledWord(string selectedWord)
        {
            return selectedWord
                    .Replace(selectedWord[RandomNumberGenerator.Next(selectedWord.Length)], '_')
                    .Replace(selectedWord[RandomNumberGenerator.Next(selectedWord.Length)], '_')
                    .Replace(selectedWord[RandomNumberGenerator.Next(selectedWord.Length)], '_');
        }
    }
}
