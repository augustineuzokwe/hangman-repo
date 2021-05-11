using System;
namespace Hangman
{
    public class ScrambleWord
    {

        private static Random randomNumber = new Random(7);

        public static String getScrambledWord(string word)
        {
            return word
                    .Replace(word[randomNumber.Next(0, word.Length)], '_')
                    .Replace(word[randomNumber.Next(0, word.Length)], '_')
                    .Replace(word[randomNumber.Next(0, word.Length)], '_');
        }
    }
}
