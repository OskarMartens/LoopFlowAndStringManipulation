using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFlowAndStringManipulation.RepeatTenTimes
{
    static class RepeatApplication
    {
        public static void App()
        {
            MenuText();
            string userInput = Console.ReadLine()!;

            if(userInput.ToUpper().Equals("M")) {
                Program.MainApplication();
            }

            int maxIter = 10;
            for (int i = 1; i <= maxIter; i++)
            {
                if(i == maxIter)
                    Console.WriteLine($"{i}. {userInput}");
                else
                    Console.Write($"{i}. {userInput}, ");
            }

            MenuTextEnd();

            userInput = Console.ReadLine()!;

            bool runMenu = true;
            while ( runMenu )
            {
                if (userInput.Equals("1"))
                {
                    runMenu = false;
                    App();
                }

                else if (userInput.Equals("2"))
                {
                    runMenu = false;
                    Program.MainApplication();
                }
                else
                   userInput = Program.NonValidInput();
            }

        }

        private static void MenuTextEnd()
        {
            Console.WriteLine("Would you like to try another input or go back?");
            Console.WriteLine("1. Try another.");
            Console.WriteLine("2. Go back.");
        }

        private static void MenuText()
        {
            Console.Clear();
            Console.WriteLine("You have selected the repeat 10 times application.");
            Console.WriteLine("Enter a text and I will repeat it for you ten times.");
            Console.WriteLine("Enter 'M' to go back to the main menu.");
        }
    }
}
