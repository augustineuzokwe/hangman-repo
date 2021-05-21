using System;
namespace Hangman
{
    public class CheckPlayerInput
    {
        public static Boolean IsCharacterInString(string selectedWord, char playerInput)
        {
            return selectedWord.Contains(playerInput.ToString());
        }
    }
}
