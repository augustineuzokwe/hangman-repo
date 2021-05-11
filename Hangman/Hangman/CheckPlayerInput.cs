using System;
namespace Hangman
{
    public class CheckPlayerInput
    {
        public static Boolean doesPlayerInputExist(string selectedWord, char playerInput)
        {
            if (selectedWord.Contains(playerInput.ToString()))
                {
                    return true;
                }
            
            return false;
        }
    }
}
