using System;
using System.Collections.Generic;


namespace Hangman
{
    public static class RandomWord
    {
        public static string getRandomWord()
        {
            Random randomNumber = new Random();
            string[] wordList = Data.words;
            int number = randomNumber.Next(1, wordList.Length);

            return wordList[number];
        }
    }
}
