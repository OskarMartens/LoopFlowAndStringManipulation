using System.Text.RegularExpressions;

namespace LoopFlowAndStringManipulation.CinemaApplication
{
    internal class CinemaIndividual
    {

        internal static void IndividualTicketPriceMenu()
        {
            CinemaText.IndividualTicketPriceMenuText();
            string userInput = Console.ReadLine()!;
            // Här kollar applikationen om input är B eller M, om det är så går flödet tillbaka till en annan applikation.
            if (userInput.ToUpper().Equals("B"))
                CinemaApp.CinemaMainMenu();
            else if (userInput.ToUpper().Equals("M"))
                Program.MainApplication();

            // Här använder jag Regex för att kolla om input är en siffra.
            // Är det inte en siffra så loopas programmet tills det kommer en siffra.
            bool isNumber = Regex.IsMatch(userInput, @"^\d+$");
            while (!isNumber)
            {
                userInput = Program.NonValidInput();
                isNumber = Regex.IsMatch(userInput, @"^\d+$");
            }

            // Här parsas input till en siffra och så hämtas en sträng från GetAgeInformation och pris från CalculateTicketPrice.
            // Ex. "For regular adults age 20 to 64, the price is:" 120
            int customerAge = int.Parse(userInput);

            string customerInfo = CinemaApp.GetAgeInformation(customerAge);
            int ticketPrice = CinemaApp.CalculateTicketPrice(customerAge);

            // Information och pris om biljett skrivs ut i nedanstående metod
            CinemaText.IndividualTicketPriceEndText(customerInfo, ticketPrice);

            // Här loopas slutmenyn.
            userInput = Console.ReadLine()!;
            bool runMenu = true;
            while (runMenu)
            {
                if (userInput.Equals("1"))
                {
                    runMenu = false;
                    IndividualTicketPriceMenu();
                }
                else if (userInput.Equals("2"))
                {
                    runMenu = false;
                    CinemaApp.CinemaMainMenu();
                }

                else if (userInput.Equals("3"))
                {
                    runMenu = false;
                    Program.MainApplication();
                }
                else
                    userInput = Program.NonValidInput();
            }
        }
    }
}
