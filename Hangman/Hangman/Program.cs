using System;
using System.Text;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random randomWord = new Random();

            string [] words = { "Street", "Storing", "Shoping", "Buying"};

            string wordsToBeDisplayed = words[randomWord.Next(words.Length)];
            ReplaceWordLetters replaceWordLetters = new ReplaceWordLetters();

            Console.Write(replaceWordLetters.ReplaceRandomLetters(wordsToBeDisplayed));

        }
    }
}


/*
- create randonm string for the game                                                             -> Done
- make it possible to print different word each time the program is run (online how to ranomize) -> Done
- for any choosen word, replace some letters with                                                -> Done
- allow user to input missing letter and show it back to user
 */