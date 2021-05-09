using System;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string [] words = { "Street", "Store", "Shop", "Buying"};

            foreach(var item in words)
                Console.WriteLine(item);

        }
    }
}
