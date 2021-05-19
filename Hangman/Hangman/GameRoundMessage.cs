using System;
using static Hangman.GameResult;

namespace Hangman
{
    public static class GameRoundMessage
    {
        public static void RoundResult(string results, string completedWord)
        {
            if (results == Results.correctInput.ToString())
                Console.WriteLine("You entered correct letter: [ {0} ] ", completedWord);
        }

        public static void RoundResult(string results)
        {
            if (results == Results.win.ToString())
            {
                Console.Write("YOU'VE WON THE GAME");
            }
            else if (results == Results.lost.ToString())
            {
                Console.WriteLine("YOU LOST THE GAME");
            }
        }

        public static void RoundResult(string results, char playerInput)
        {
            if (results == Results.wrongInput.ToString())
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
