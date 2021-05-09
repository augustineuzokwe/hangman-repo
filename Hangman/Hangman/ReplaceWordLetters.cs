using System;
namespace Hangman
{
    public class ReplaceWordLetters
    {

        private Random randomNumber = new Random(7);

        public ReplaceWordLetters()
        {
        }

        public String ReplaceRandomLetters(string word)
        {
            return word
                    .Replace(word[randomNumber.Next(0, word.Length)], '_')
                    .Replace(word[randomNumber.Next(0, word.Length)], '_')
                    .Replace(word[randomNumber.Next(0, word.Length)], '_');
        }
    }
}
