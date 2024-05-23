using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//namespace LoopFlowAndStringManipulation.CinemaApplication {
//    internal class CinemaIndividual {

//        internal static void IndividualTicketPriceMenu() {
//            CinemaText.IndividualTicketPriceMenuText();
//            string userInput = Console.ReadLine()!;

//            if (userInput.ToUpper().Equals("B"))
//                CinemaApp.CinemaMainMenu();
//            else if (userInput.ToUpper().Equals("M"))
//                MainApplication();

//            bool isNumber = Regex.IsMatch(userInput, @"^\d+$");

//            while (!isNumber) {
//                userInput = NonValidInput();
//                isNumber = Regex.IsMatch(userInput, @"^\d+$");
//            }

//            int customerAge = int.Parse(userInput);

//            string customerInfo = GetAgeInformation(customerAge);
//            int ticketPrice = CalculateTicketPrice(customerAge);

//            IndividualTicketPriceEndText(customerInfo, ticketPrice);
//            userInput = Console.ReadLine()!;

//            bool validInput = userInput.Equals("1") || userInput.Equals("2") || userInput.Equals("3");
//            while (!validInput) {
//                userInput = NonValidInput();
//                validInput = userInput.Equals("1") || userInput.Equals("2") || userInput.Equals("3");
//            }
//            if (userInput.Equals("1"))
//                IndividualTicketPriceMenu();
//            else if (userInput.Equals("2"))
//                CinemaMainMenu();
//            else if (userInput.Equals("3"))
//                MainApplication();
//        }
//    }
//}
