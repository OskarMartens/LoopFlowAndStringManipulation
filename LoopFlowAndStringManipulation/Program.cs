namespace LoopFlowAndStringManipulation {
    internal class Program {
        static void Main(string[] args) {
            MainApplication();
        }

        static void MainApplication() {
            string userInput;
            do{
                MainMenuText();
                userInput = Console.ReadLine()!;
                switch (userInput) {
                    case "1":
                        CinemaMainMenu();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        userInput = NotValidInput();
                        break;
                }
            } while (userInput != "0");
        }

        static void MainMenuText() {
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
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Please make your choice between 1, 2, 3 or 0 to exit.");
        }

        static void CinemaMainMenu() {
            CinemaMainMenuText();
            string userInput = Console.ReadLine()!;
        }
        static void CinemaMainMenuText() {
            Console.WriteLine("");
            Console.WriteLine("*************************");
            Console.WriteLine("You have selected the Cinema application.");
            Console.WriteLine("In this application you can check the ticket price depending on age.");
            Console.WriteLine("You can also check the total sum for a party of customers.");
            Console.WriteLine("Here is the list with corresponding numbers:");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1. Individual ticket price.");
            Console.WriteLine("2. Total price for a party.");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please make your choice");
        }

        static string NotValidInput() {
            Console.WriteLine("The provided input is not valid.");
            Console.WriteLine("Please enter a valid number:");
            return Console.ReadLine()!;
        }
    }
}
