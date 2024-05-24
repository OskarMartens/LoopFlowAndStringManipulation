using LoopFlowAndStringManipulation.CinemaApplication;
using LoopFlowAndStringManipulation.RepeatTenTimes;
using LoopFlowAndStringManipulation.ThirdWord;
/*
 * 
 * Kul uppgift men den var lite klurig! Det svåra var att bryta ut programmet till separata klasser och metoder.
 * 
 * Det var också svårt med looparna som körde menyerna.
 * Jag hade ett problem med menyer från andra program som stannade kvar.
 * Jag löste detta med tydligen bryta alla loopar när ett val gjordes.
 * 
 * I genom alla applikationer har jag försökt lägga texterna som en egen metod längst ner i klasserna.
 * 
 * Mitt genomgående tankesätt är att alltid försöka "fail fast".
 * Dvs bland det första koden kollar är om input inte är giltig. Först efter det skapar jag variabler och gör andra operationer.
 * 
 * Det jag skulle vilja lära mig är att skriva bra och "clean" kod samt hur den kan refaktoreras.
 * 
 * Det jag undrar över är också om användandet av statiska klassar i dessa projekt är bra eller ska jag skapa objekt istället?
 * 
 * Jag försöker också skriva självdokumenterande kod.
 * 
 * */
namespace LoopFlowAndStringManipulation
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            MainApplication();
        }

        public static void MainApplication()
        {
            string userInput;
            bool isRunning = true;
            do
            {
                MainMenuText();
                userInput = Console.ReadLine()!;
                bool runMenu = true;
                while (runMenu)
                {
                    switch (userInput)
                    {
                        case "1":
                            runMenu = false;
                            isRunning = false;
                            CinemaApp.CinemaMainMenu();
                            break;
                        case "2":
                            runMenu = false;
                            isRunning = false;
                            RepeatApplication.App();
                            break;
                        case "3":
                            runMenu = false;
                            isRunning = false;
                            ThirdWordApp.App();
                            break;
                        case "0":
                            runMenu = false;
                            isRunning = false;
                            break;
                        default:
                            userInput = NonValidInput();
                            break;
                    }
                }
            } while (isRunning);
        }


        static void MainMenuText()
        {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("Welcome to the main menu.");
            Console.WriteLine("*************************");
            Console.WriteLine("This application consists of three different smaller applications.");
            Console.WriteLine("The applications will be presented here in a numbered list.");
            Console.WriteLine("In order to enter an application press the corresponding number in the console.");
            Console.WriteLine("If you would like to exit the application, press \"0\".");
            Console.WriteLine("Here are the applications to choose from:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. Cinema application.");
            Console.WriteLine("2. \"Repeat 10 times\".");
            Console.WriteLine("3. \"The third word\".");
            Console.WriteLine("0. Exit application.");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Please make your choice between 1, 2, 3 or 0.");
        }
        // Den metoden används vid flera tillfällen i applikationen.
        public static string NonValidInput()
        {
            Console.WriteLine("The provided input is not valid.");
            Console.WriteLine("Please enter a valid input:");
            return Console.ReadLine()!;
        }
    }
}
