using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFlowAndStringManipulation.CinemaApplication {
    static class CinemaApp {

        static void CinemaMainMenu() {
            string userInput;
            bool isRunning = true;
            do {
                CinemaText.CinemaMainMenuText();
                userInput = Console.ReadLine()!;
                switch (userInput) {
                    case "1":
                        //CinemaText.IndividualTicketPriceMenu();
                        break;
                    case "2":
                        break;

                }
            } while (isRunning);
        }
    }
}
