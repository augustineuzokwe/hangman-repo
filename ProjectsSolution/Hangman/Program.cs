using System;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string word = Data.GetWord();
            string scrambledWord = ScrambleWord.GetScrambledWord(word);
            char[] gameWord = scrambledWord.ToCharArray();


            GameUI.WelcomeToHangmanGame(scrambledWord);

            while (!GameCore.GameOver)
            {
                char playerInput = GameUI.GetPlayerInput();

                var result = GameCore.Play(word, gameWord, playerInput);

                GameUI.GameRoundResult(result, GameResult.CompletedWord, playerInput);

            };
        }

    }
}