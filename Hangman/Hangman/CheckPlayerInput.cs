using System;
namespace Hangman
{
    public class CheckPlayerInput
    {
        internal static Boolean IsCharacterInString(string selectedWord, char playerInput)
        {
            if (selectedWord.Contains(playerInput.ToString()))
                {
                    return true;
                }
            
            return false;
        }
    }
}
