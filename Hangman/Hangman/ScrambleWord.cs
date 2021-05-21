using System;
namespace Hangman
{
    public class ScrambleWord
    {

        private static Random randomNumberGenerator = new Random();

        public static string getScrambledWord(string selectedWord)
        {
            return selectedWord
                    .Replace(selectedWord[randomNumberGenerator.Next(selectedWord.Length)], '_')
                    .Replace(selectedWord[randomNumberGenerator.Next(selectedWord.Length)], '_')
                    .Replace(selectedWord[randomNumberGenerator.Next(selectedWord.Length)], '_');
        }
    }
}
