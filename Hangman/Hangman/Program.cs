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


            GameUI.WelcomeToHangmanGame(scrambledWord);

            while (!GameRound.GameOver)
            {
                char playerInput = GameUI.GetPlayerInput();

                GameRound.Play(word, gameWord, playerInput, out GameResult.Result result, out string completedWord);

                GameUI.GameRoundResult(result, completedWord, playerInput);

            };
        }

    }
}