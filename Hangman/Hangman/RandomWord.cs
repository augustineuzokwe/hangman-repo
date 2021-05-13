using System;
using System.Collections.Generic;


namespace Hangman
{
    public class RandomWord
    {
        public string getRandomWord()
        {
            Random randomNumber = new Random();
            List<string> wordList = new List<string> { "street", "storing", "shopping", "buying", "skating" };
            int number = randomNumber.Next(1, wordList.Count);

            return wordList[number];
        }
    }
}
