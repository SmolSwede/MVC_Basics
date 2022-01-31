using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Models
{
    public class NumberGuessingGame
    {
        public static int generatedNum;
        public static int GenerateNum()
        {
            Random random = new Random();
            generatedNum = random.Next(1, 101);
            return generatedNum;
        }

        public static string GuessCheck(int inputNum, out bool win)
        {
            win = false;

            if(inputNum == generatedNum)
            {
                win = true;
                return "You'ev guessed the right number";
            }
            else if(inputNum < generatedNum)
            {
                return "Guessed number is to low";
            }
            else if (inputNum > generatedNum)
            {
                return "Guessed number is to high";
            }
            else
            {
                return "Something whent wrong";
            }
        }
    }
}
