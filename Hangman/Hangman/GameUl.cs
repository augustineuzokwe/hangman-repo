using System;
namespace Hangman
{
    public class GameUI
    {
        public static char GetPlayerInput()
        {
            return Char.Parse(Console.ReadLine());
        }

        public static void WelcomeToHangmanGame(string scrambledWord)
        {
            Console.WriteLine("Here is the word for Hangman game, please fill in each letter");
            Console.WriteLine(scrambledWord);

            Console.WriteLine("Welcome To Hangman game.\n");
            Console.WriteLine("Enter a letter... \n");
        }

        public static void GameRoundResult(GameResult.Result result, string completedWord = "", char playerInput = ' ')
        {
            switch (result)
            {
                case GameResult.Result.correctInput:
                    Console.WriteLine($"You entered correct letter: [ {playerInput} ] - Game completed word: [ {completedWord} ] \n\nEnter a new letter: ");
                    break;
                case GameResult.Result.win:
                    Console.WriteLine($"Game completed: [ {completedWord} ]: \n\n YOU'VE WON THE GAME");
                    break;
                case GameResult.Result.lost:
                    Console.WriteLine($"You have entered a wrong letter: [ { playerInput } ] and used up your joker.\n\n YOU LOST THE GAME");
                    break;
                case GameResult.Result.wrongInput:
                    Console.WriteLine($"You have entered a wrong letter: [ { playerInput } ] you have Few more chance....\n\nEnter a new letter: ");
                    break;
            }
        }
    }
}
