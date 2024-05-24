namespace LoopFlowAndStringManipulation.CinemaApplication
{
    static class CinemaApp
    {
        public static void CinemaMainMenu()
        {
            string userInput;
            bool isRunning = true;
            do
            {
                CinemaText.CinemaMainMenuText();
                userInput = Console.ReadLine()!;
                switch (userInput)
                {
                    case "1":
                        isRunning = false;
                        CinemaIndividual.IndividualTicketPriceMenu();
                        break;
                    case "2":
                        isRunning = false;
                        CinemaGroup.GroupCinemaMenu();
                        break;
                }
            } while (isRunning);
        }

        // Här är metoderna för att beräkna pris och ge information om ålder.
        // Jag har lagt till barn under 5 och pensionärer över 100.
        // I mitt fall behövde jag inte ha en koll på negativa nummer. Ex input == -1.
        // Eftersom -1 inte är en int.
        // Det jag skulle kunna gjort bättre är kanske listan över bools. Inte upprepa de två gånger.
        public static string GetAgeInformation(int age)
        {
            bool child = age < 5;
            bool youth = age < 20 && age >= 5;
            bool senior = age >= 65 && age <= 100;
            bool oldSenior = age > 100;

            if (child)
                return "For children under the age of 5, the price is:";
            else if (youth)
                return "For youth, five years or older and younger than 20, the price is:";
            else if (senior)
                return "For seniors 65 years or older and younger than 100, the price is:";
            else if (oldSenior)
                return "For people over the age of 100 the price is:";
            else
                return "For regular adults age 20 to 64, the price is:";
        }

        public static int CalculateTicketPrice(int age)
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
    }
}
