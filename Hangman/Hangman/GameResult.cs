using System;

namespace Hangman
{
    public class GameResult
    {
        public static string CompletedWord { get; set; }

        public enum Result
        {
            win,
            lost,
            wrongInput,
            correctInput
        }
    }
}
