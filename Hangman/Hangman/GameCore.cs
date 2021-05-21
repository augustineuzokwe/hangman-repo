using System;
namespace Hangman
{
    public static class GameCore
    {

        private static int wrongInputCount = 0;
        private static int errorLimit = 3;
        public static GameResult.Result gameResult;

        public static bool GameOver { get; set; }

        public static void Play(string word, char[] gameWord, char playerInput, out GameResult.Result gameResult, out string completedWord)
        {
            gameResult = 0;
            completedWord = "";

            if (CheckPlayerInput.IsCharacterInString(word, playerInput))
            {
                for (int y = 0; y < word.Length; y++)
                {
                    if (word[y] == playerInput)
                    {
                        gameWord[y] = playerInput;
                        completedWord = new string(gameWord);

                        gameResult = GameResult.Result.correctInput;
                    }
                }

                if (completedWord.Equals(word))
                {
                    gameResult = GameResult.Result.win;
                    GameOver = true;
                    return;
                }
            }
            else
            {
                wrongInputCount++;
                gameResult = GameResult.Result.wrongInput;

                if (wrongInputCount == errorLimit)
                {
                    gameResult = GameResult.Result.lost;
                    GameOver = true;
                    return;
                }
            }
        }
    }
}
