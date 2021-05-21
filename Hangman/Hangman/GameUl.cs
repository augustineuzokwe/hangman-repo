using System;
namespace Hangman
{
    public class GameUl
    {
        public static char getPlayerInput()
        {
            var input = Char.Parse(Console.ReadLine());

            return input;
        }
    }
}
