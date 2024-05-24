namespace LoopFlowAndStringManipulation.RepeatTenTimes
{
    static class RepeatApplication
    {
        public static void App()
        {
            MenuText();
            string userInput = Console.ReadLine()!;

            if (userInput.ToUpper().Equals("M"))
            {
                Program.MainApplication();
            }

            // Jag använder en variable, iterCount, för att den sista utskriften ska vara utan ett komma-tecken.
            // Jag la också in {i}. mest för att hålla koll själv på hur många utskrifter det blev.
            // Ex. 1. Hej, 2. Hej, ... 10. Hej
            int iterCount = 10;
            for (int i = 1; i <= iterCount; i++)
            {
                if (i == iterCount)
                    Console.WriteLine($"{i}. {userInput}");
                else
                    Console.Write($"{i}. {userInput}, ");
            }

            MenuTextEnd();

            userInput = Console.ReadLine()!;
            // Här använder jag också en loop för att vänta på att användaren ger giltig input.
            bool runMenu = true;
            while (runMenu)
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
        // Här är menytexterna.
        private static void MenuTextEnd()
        {
            Console.WriteLine("");
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
