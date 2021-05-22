using System;
namespace Hangman
{
    public static class GameCore
    {

        private static int wrongInputCount = 0;
        private static int errorLimit = 3;
        public static GameResult.Result gameResult;

        public static bool GameOver { get; set; }

        public static GameResult.Result Play(string word, char[] gameWord, char playerInput)
        {

            if (word.Contains(playerInput.ToString()))
            {
                for (int y = 0; y < word.Length; y++)
                {
                    if (word[y] == playerInput)
                    {
                        gameWord[y] = playerInput;
                        GameResult.CompletedWord = new string(gameWord);

                        gameResult = GameResult.Result.correctInput;
                    }
                }

                if (GameResult.CompletedWord.Equals(word))
                {
                    gameResult = GameResult.Result.win;
                    GameOver = true;
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
                }
            }

            return gameResult;
        }
    }
}
