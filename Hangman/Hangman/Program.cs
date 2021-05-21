using System;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string word = Data.getWord();
            string scrambledWord = ScrambleWord.getScrambledWord(word);
            char[] gameWord = scrambledWord.ToCharArray();

            GameRoundMessage.WelcomeToHangmanGame(scrambledWord);

            while (!GameRound.GameOver)
            {
                char playerInput = GameUl.getPlayerInput();

                GameRound.Play(word, gameWord, playerInput);

            };
        }

    }
}