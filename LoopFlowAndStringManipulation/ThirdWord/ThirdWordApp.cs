/*
 * 
 * I denna applikation hade jag problem med att bryta looparna när jag försökte
 * bryta ut App-metoden till mindre metoder. Så nu ligger all kod i en och samma metod.
 * Även här skulle jag vilja se hur bra refaktorering skulle kunna se ut.
 * 
 * */

namespace LoopFlowAndStringManipulation.ThirdWord
{
    static class ThirdWordApp
    {
        public static void App()
        {
            MenuText();
            string userInput = Console.ReadLine()!;
            //Här börjar input av menyn köras. Jag gjorde detta som en loop för att ta input tills den är korrekt.
            // Dvs. Det är möjligt att ge fel input hur många gånger som helst men när en giltig input ges bryts loopen.
            bool runApp = true;
            while (runApp)
            {
                // Om input är b eller B körs huvudapplikationen istället.
                if (userInput.ToUpper().Equals("B"))
                {
                    runApp = false;
                    Program.MainApplication();
                }
                // Om input startar eller slutar med ett blanksteg så blir det ett fel och användaren uppmanas att uppdatera userInput
                bool startsOrEndWithBlank = (userInput[0] == ' ') || userInput[userInput.Length - 1] == ' ';
                if (startsOrEndWithBlank)
                {
                    Console.WriteLine("A sentence cannot start or end with a blank space.");
                    userInput = Program.NonValidInput();
                }
                // Annars om input inte är b eller den slutar eller starta med blanksteg går programmet vidare.
                else
                {
                    // Precis nedanför är ett tecken på hur jag försöker koda. Innan denna punkt behöver jag inte en lista med ord.
                    // Det hade varit onödigt att skapa listan om det är så att flödet ändå hade brutits vid en tidigare punkt.
                    string[] wordList = userInput.Split(" ");
                    // Om listan består av färre en tre ord så är det också icke giltig input.
                    if (wordList.Length < 3)
                    {
                        Console.WriteLine("The provided sentence contains less than three words.");
                        userInput = Program.NonValidInput();
                    }
                    else
                    {
                        Console.WriteLine($"The third word is: {wordList[2]}");
                        // Här behövde jag en ytterligare loop för att hantera hur användaren vill avsluta programmet.
                        bool runMenu = true;
                        while (runMenu)
                        {
                            MenuTextEnd();
                            userInput = Console.ReadLine()!;
                            if (userInput.Equals("1"))
                            {
                                runMenu = false;
                                runApp = false;
                                App();
                            }
                            else if (userInput.Equals("2"))
                            {
                                runMenu = false;
                                runApp = false;
                                Program.MainApplication();
                            }
                            else
                            {
                                Console.WriteLine("The input is not valid. Please enter a valid input");
                            }
                        }
                    }
                }
            }
        }

        private static void MenuTextEnd()
        {
            Console.WriteLine("Would you like to try another sentence or go back to the main menu?");
            Console.WriteLine("Enter the corresponding number.");
            Console.WriteLine("1. Try again.");
            Console.WriteLine("2. Back to the main menu");
        }

        private static void MenuText()
        {
            Console.Clear();
            Console.WriteLine("You have selected the Third word application.");
            Console.WriteLine("Enter a sentence that contains at least three(3) words.");
            Console.WriteLine("The application will then print out the third word of that sentence.");
            Console.WriteLine("If you would like to go back enter 'B'");
        }
    }
}
