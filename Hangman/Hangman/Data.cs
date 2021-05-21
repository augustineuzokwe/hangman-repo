using System;
using System.Collections.Generic;


namespace Hangman
{
    public static class Data
    {
        public static List<string> Words()
        {
            return new List<string> { "Street", "Storing", "Shopping", "Buying" };
        } 

        public static string getWord()
        {
            Random randomNumber = new Random();
            var wordList = Words();
            int number = randomNumber.Next(wordList.Count);

            return wordList[number];
        }
    }


}
