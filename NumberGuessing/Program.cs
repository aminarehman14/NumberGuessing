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

            do {
                Console.Write("Enter a number between 1 to 100 "); 
                //todo accept user input ("read user input from console c#"
                string i = Console.ReadLine();

                int x = int.Parse(i);
                // TODO write statement that checks if a number is less than or higher than the RIGHTNUM and write too high 
                //if the entered num is too high and too low if the answer is too low
                // if the answer is right print that is correct and set win = true


            } while (correct == false); 

            Console.ReadLine(); 
        }
    }
}
