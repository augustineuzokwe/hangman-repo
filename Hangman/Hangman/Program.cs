using System;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string word = RandomWord.getRandomWord();
            string scrambledWord = ScrambleWord.getScrambledWord(word);
            char[] gameWord = scrambledWord.ToCharArray();

            GameRoundMessage.WelcomeToHangmanGame(scrambledWord);

            while (!GameRound.GameOver)
            {
                char playerInput = GameRound.GetPlayerInput(Console.ReadLine());

                GameRound.Play(word, gameWord, playerInput);

            };
        }

    }
}