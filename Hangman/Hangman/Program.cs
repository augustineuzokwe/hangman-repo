using System;
using System.Text;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            RandomWord randomWord = new RandomWord();
            String selectedWord = randomWord.getRandomWord();
            String scrambledWord = ScrambleWord.getScrambledWord(selectedWord);
            char[] gameWord = scrambledWord.ToCharArray();

            Console.WriteLine("Here is the word for Hangman game, please fill in each letter");
            Console.WriteLine(scrambledWord);

            GamePlay.play(selectedWord, gameWord);
        }

    }
}