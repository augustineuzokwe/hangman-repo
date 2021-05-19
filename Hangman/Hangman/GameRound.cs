            using System;
            namespace Hangman
            {
            public static class GameRound
            {

                private static int wrongInputCount = 0;
                private static string completedWord = "";
                private static int errorLimit = 3;

                public static bool GameOver {get;set;}

                    public static char GetPlayerInput(string input)
                    {
                        var x = input.ToCharArray();

                        //need fixing
                        if (char.IsLetter(x[0]))
                            return x[0];

                        return '-';
                    }

                    public static void Play(string word, char[] gameWord, char playerInput)
                    {
                        if (CheckPlayerInput.IsCharacterInString(word, playerInput))
                        {

                          for (int y = 0; y < word.Length; y++)
                                {
                                    if (word[y] == playerInput)
                                    {
                                        gameWord[y] = playerInput;
                                        completedWord = new string(gameWord);

                                        GameRoundMessage.RoundResult(GameResult.Results.correctInput.ToString(), completedWord);

                                    }
                                }

                                if (completedWord.Equals(word))
                                {
                                    GameRoundMessage.RoundResult(GameResult.Results.win.ToString());
                            GameOver = true;
                                    return;
                                }
                            }
                            else
                            {
                                wrongInputCount++;
                                GameRoundMessage.RoundResult(GameResult.Results.wrongInput.ToString(), playerInput);

                                if (wrongInputCount == errorLimit)
                                {
                                    GameRoundMessage.RoundResult(GameResult.Results.lost.ToString());
                        GameOver = true;
                        return;
                                }
                            }
                    }
                }
            }
