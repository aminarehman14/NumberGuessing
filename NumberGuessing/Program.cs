using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();

            int RightNum = R.Next(0, 100);

            bool correct = false;
            bool parseSuccess = false;
            do
            {
                Console.Write("Enter a number between 1 to 100 ");
                //todo accept user input ("read user input from console c#"
                string guessedNum = Console.ReadLine();

                //exception for no input
                while (string.IsNullOrEmpty(guessedNum))
                {
                    Console.WriteLine("Ain't nobody got time fo dat, guess a number >:|");
                    guessedNum = Console.ReadLine();
                }

                //exception for invalid input
                while (parseSuccess == false)
                {
                    parseSuccess = int.TryParse(guessedNum, out int guess);

                    if (parseSuccess == false)
                    {
                        Console.WriteLine("Just a number loser");
                        guessedNum = Console.ReadLine();
                    }
                } 



                // TODO write statement that checks if a number is less than or higher than the RIGHTNUM and write too high 
                //if the entered num is too high and too low if the answer is too low
                // if the answer is right print that is correct and set win = true
                /*
                switch (x)
                {
                    case x == RightNum:
                        Console.WriteLine("shaBAAM You right.");
                        correct = true;
                        break;
                    case x > RightNum:
                        Console.WriteLine("Too high.  Try again");
                        break;
                    case x < RightNum:
                        Console.WriteLine("Too low. Try again");
                        break;
                    default:
                        Console.WriteLine("Nothing to say.");
                        break;
                }
                */
                int x = int.Parse(guessedNum);

                if (x == RightNum)
                {
                    Console.WriteLine("shaBAAM You right.");
                    correct = true;
                }
                else if (x > RightNum)
                {
                    Console.WriteLine("Too high.  Try again");
                }
                else if (x < RightNum)
                {
                    Console.WriteLine("Too low. Try again");
                }
                else
                {
                    Console.WriteLine("Nothing to say.");
                }



            } while (correct == false); 

            Console.WriteLine("Games over, go home.");
            Console.WriteLine("Press Enter to exit");

            string choice = Console.ReadLine();
        }
    }
}
