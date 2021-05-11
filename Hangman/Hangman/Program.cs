using System;
using System.Text;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            RandomWord randomWord = new RandomWord();
            String selectedWord = randomWord.getRandomWord();
            String scrambledWord = ScrambleWord.getScrambledWord(selectedWord);
            char[] gameWord = scrambledWord.ToCharArray();

            Console.WriteLine("Here is the word for Hangman game, please fill in each letter");
            Console.WriteLine(scrambledWord);

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

                        if (completedWord.Equals(selectedWord))
                            Console.Write("YOU'VE WON THE GAME");
                    }
                }
                else
                {
                    wrongInputCount++;

                    Console.WriteLine("you have entered a wrong letter: [ {0} ] you have Few more chance....", playerInput);

                    if (wrongInputCount == 5)
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