using System;

namespace Hangman
{
    public class GameResult
    {
        public enum Result
        {
            win,
            lost,
            wrongInput,
            correctInput
        }
    }
}
