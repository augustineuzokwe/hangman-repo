using System;
namespace Hangman
{
    public class GamePlay
    {
        public static void play(string selectedWord, char[] gameWord)
        {
            int count = 0;
            string completedWord = "";
            int wrongInputCount = 0;
            do
            {
                count++;

                Console.WriteLine("");
                Console.WriteLine("Enter a letter... ");
                char playerInput = char.Parse(Console.ReadLine());

                if (CheckPlayerInput.doesPlayerInputExist(selectedWord, playerInput))
                {
                    for (int y = 0; y < selectedWord.Length; y++)
                    {
                        if (selectedWord[y] == playerInput)
                        {
                            gameWord[y] = playerInput;
                            completedWord = new string(gameWord);
                            Console.WriteLine("You hit a node!: {0} ", completedWord);
                        }
                    }

                    if (completedWord.Equals(selectedWord))
                    {
                        Console.Write("YOU'VE WON THE GAME");
                        break;
                    }
                }
                else
                {
                    wrongInputCount++;

                    Console.WriteLine("you have entered a wrong letter: [ {0} ] you have Few more chance....", playerInput);

                    if (wrongInputCount == 2)
                    {
                        Console.WriteLine("YOU LOST THE GAME");
                        break;
                    }
                }
            }
            while (count <= selectedWord.Length);
        }
    }
}
