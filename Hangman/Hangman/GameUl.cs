using System;
namespace Hangman
{
    public class GameUI
    {
        public static char GetPlayerInput()
        {
            return Char.Parse(Console.ReadLine());
        }

        public static void GameRoundResult(GameResult.Result result, string completedWord = "", char playerInput=' ')
        {
            switch (result)
            {
                case GameResult.Result.correctInput:
                    Console.WriteLine("You entered correct letter: [ {0} ] ", completedWord);
                    break;
                case GameResult.Result.win:
                    Console.Write("YOU'VE WON THE GAME");
                    break;
                case GameResult.Result.lost:
                    Console.WriteLine("YOU LOST THE GAME");
                    break;
                case GameResult.Result.wrongInput:
                    Console.WriteLine("you have entered a wrong letter: [ {0} ] you have Few more chance....", playerInput);
                    break;
            }
        }

        public static void WelcomeToHangmanGame(string scrambledWord)
        {
            Console.WriteLine("Here is the word for Hangman game, please fill in each letter");
            Console.WriteLine(scrambledWord);

            Console.WriteLine("Welcome To Hangman game.\n");
            Console.WriteLine("Enter a letter... \n");
        }
    }
}
