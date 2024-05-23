using LoopFlowAndStringManipulation.CinemaApplication;
using LoopFlowAndStringManipulation.RepeatTenTimes;
using System.Text.RegularExpressions;

namespace LoopFlowAndStringManipulation
{
    static class Program
    {

        static void Main(string[] args)
        {
            //MainApplication();
            //CinemaMainMenu();
            //IndividualTicketPriceMenu();
            //GroupCinemaMenu();
            RepeatApplication.App();
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
                            CinemaMainMenu();
                            break;
                        case "2":
                            RepeatApplication.App();
                            break;
                        case "3":
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

        static void CinemaMainMenu()
        {
            string userInput;
            bool isRunning = true;
            do
            {
                CinemaMainMenuText();
                userInput = Console.ReadLine()!;
                switch (userInput)
                {
                    case "1":
                        IndividualTicketPriceMenu();
                        break;
                    case "2":
                        GroupCinemaMenu();
                        break;
                }
            } while (isRunning);
        }

        static void IndividualTicketPriceMenu()
        {
            IndividualTicketPriceMenuText();
            string userInput = Console.ReadLine()!;

            if (userInput.ToUpper().Equals("B"))
                CinemaMainMenu();
            else if (userInput.ToUpper().Equals("M"))
                MainApplication();

            bool isNumber = Regex.IsMatch(userInput, @"^\d+$");

            while (!isNumber)
            {
                userInput = NonValidInput();
                isNumber = Regex.IsMatch(userInput, @"^\d+$");
            }

            int customerAge = int.Parse(userInput);

            string customerInfo = GetAgeInformation(customerAge);
            int ticketPrice = CalculateTicketPrice(customerAge);

            IndividualTicketPriceEndText(customerInfo, ticketPrice);
            userInput = Console.ReadLine()!;

            bool runMenu = true;
            while (runMenu)
            {
                if (userInput.Equals("1"))
                    IndividualTicketPriceMenu();
                else if (userInput.Equals("2"))
                    CinemaMainMenu();
                else if (userInput.Equals("3"))
                    MainApplication();
                else
                    userInput = NonValidInput();
            }
        }
        
        static void GroupCinemaMenu()
        {
            GroupCinemaMenuText();

            int groupCost = 0;
            List<int> groupAges = new List<int>();

            bool runMenu = true;
            while (runMenu)
            {
                string userInput = Console.ReadLine()!;
                bool isNumber = Regex.IsMatch(userInput, @"^\d+$");

                if (userInput.ToUpper().Equals("C"))
                {
                    if (!groupAges.Any())
                    {
                        Console.WriteLine("There are no members in this group.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        GroupCinemaMenu();
                    }
                    else
                    {
                        Console.WriteLine("The members' ages are:");
                        foreach (int age in groupAges)
                        {
                            Console.WriteLine(age);
                        }
                        Console.WriteLine("The total cost for the group is: ");
                        Console.WriteLine(groupCost);
                        Console.WriteLine("Press any key to go back.");
                        Console.ReadLine();
                        groupAges.Clear();
                        groupCost = 0;
                        GroupCinemaMenu();
                    }
                }
                else if (userInput.ToUpper().Equals("B"))
                {
                    runMenu = false;
                    CinemaMainMenu();
                } 
                else if (userInput.ToUpper().Equals("M"))
                {
                    runMenu = false;
                    MainApplication();
                }
                else if(isNumber)
                {
                    int customerAge = int.Parse(userInput);
                    groupCost += CalculateTicketPrice(customerAge);
                    groupAges.Add(customerAge);
                }
                else
                    userInput = NonValidInput();
            }
        }

        static string GetAgeInformation(int age)
        {
            bool child = age < 5;
            bool youth = age < 20 && age >= 5;
            bool senior = age >= 65 && age <= 100;
            bool oldSenior = age > 100;

            if (child)
                return "For children under the age of 5, the price is:";
            else if (youth)
                return "For youth five years or older and younger than 20, the price is:";
            else if (senior)
                return "For seniors 65 years or older and younger than 100, the price is:";
            else if (oldSenior)
                return "For people over the age of 100 the price is:";
            else
                return "For regular adults age 20 to 64, the price is:";
        }

        static int CalculateTicketPrice(int age)
        {
            bool child = age < 5;
            bool youth = age < 20 && age >= 5;
            bool senior = age >= 65 && age <= 100;
            bool oldSenior = age > 100;

            if (child || oldSenior)
                return 0;
            else if (youth)
                return 80;
            else if (senior)
                return 90;
            else
                return 120;
        }

        private static void IndividualTicketPriceEndText(string customerInfo, int ticketPrice)
        {
            Console.WriteLine($"{customerInfo} {ticketPrice} SEK.");
            Console.WriteLine("");
            Console.WriteLine("Would you like to enter a new age, go back to the cinema menu or go to the main menu?");
            Console.WriteLine("1. New age.");
            Console.WriteLine("2. Go back to the cinema menu");
            Console.WriteLine("3. Go back to main menu");
        }

        static void GroupCinemaMenuText()
        {
            Console.Clear();
            Console.WriteLine("You have come to the GroupCinemaMenu");
            Console.WriteLine("Enter the ages of the group members.");
            Console.WriteLine("Enter 'C' to calculate the price and see the group members' ages");
            Console.WriteLine("Enter 'B' to go back to the cinema menu and 'M' to go to the main menu");
        }


        static void IndividualTicketPriceMenuText()
        {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("You have selected individual ticket price");
            Console.WriteLine("In order to go back to the main menu enter 'M'");
            Console.WriteLine("In order to go back to the cinema menu enter 'B'");
            Console.WriteLine("Otherwise please enter the age of the customer:");
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

        static void CinemaMainMenuText()
        {
            Console.Clear();
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
            Console.WriteLine("Please make your choice:");
        }
        public static string NonValidInput()
        {
            Console.WriteLine("The provided input is not valid.");
            Console.WriteLine("Please enter a valid input:");
            return Console.ReadLine()!;
        }
    }
}

