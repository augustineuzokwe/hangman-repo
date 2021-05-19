using System;
namespace Hangman
{
    public class ScrambleWord
    {

        private static Random randomNumber = new Random(7);

        public static string getScrambledWord(string selectedWord)
        {
            return selectedWord
                    .Replace(selectedWord[randomNumber.Next(0, selectedWord.Length)], '_')
                    .Replace(selectedWord[randomNumber.Next(0, selectedWord.Length)], '_')
                    .Replace(selectedWord[randomNumber.Next(0, selectedWord.Length)], '_');
        }
    }
}
