using System;
using static Hangman.GameResult;

namespace Hangman
{
    public static class GameRoundMessage
    {


        public static void RoundResult(GameResult.Results result, string completedWord)
        {
            if (result == GameResult.Results.correctInput)
                Console.WriteLine("You entered correct letter: [ {0} ] ", completedWord);
        }

        public static void RoundResult(GameResult.Results result)
        {
            if (result == Results.win)
            {
                Console.Write("YOU'VE WON THE GAME");
            }
            else if (result == Results.lost)
            {
                Console.WriteLine("YOU LOST THE GAME");
            }
        }

        public static void RoundResult(GameResult.Results result, char playerInput)
        {
            if (result == Results.wrongInput)
                Console.WriteLine("you have entered a wrong letter: [ {0} ] you have Few more chance....", playerInput);
        }


        public static void WelcomeToHangmanGame(string scrambledWord)
        {
            Console.WriteLine("Here is the word for Hangman game, please fill in each letter");
            Console.WriteLine(scrambledWord);

            Console.WriteLine("Welcome To Hangman game.\n\n");
            Console.WriteLine("Enter a letter... \n");
        }
    }
}
