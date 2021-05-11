using System;
namespace Hangman
{
    public class RandomWord
    {
        public string getRandomWord()
        {
            Random randomNumber = new Random();

            int number = randomNumber.Next(1, Data.words.Length);

            string randomWord = "";

            switch (number)
            {
                case 1:
                    randomWord = Data.words[number];
                    break;

                case 2:
                    randomWord = Data.words[number];
                    break;

                case 3:
                    randomWord = Data.words[number];
                    break;

                case 4:
                    randomWord = Data.words[number];
                    break;
            }

            return randomWord;
        }
    }
}
