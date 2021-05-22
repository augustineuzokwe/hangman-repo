using System;
using System.Collections.Generic;


namespace Hangman
{
    public static class Data
    {
        public static List<string> GetWords()
        {
            return new List<string> { "street", "storing", "shopping", "buying" };
        }

        public static string GetWord()
        {
            Random randomNumber = new Random();
            var wordList = GetWords();
            int number = randomNumber.Next(wordList.Count);

            return wordList[number];
        }
    }
}
