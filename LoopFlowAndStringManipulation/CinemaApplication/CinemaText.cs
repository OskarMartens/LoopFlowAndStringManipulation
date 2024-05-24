namespace LoopFlowAndStringManipulation.CinemaApplication
{
    internal static class CinemaText
    {
        public static void CinemaMainMenuText()
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
        public static void IndividualTicketPriceMenuText()
        {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("You have selected individual ticket price");
            Console.WriteLine("In order to go back to the main menu enter 'M'");
            Console.WriteLine("In order to go back to the cinema menu enter 'B'");
            Console.WriteLine("Otherwise please enter the age of the customer:");
        }
        public static void IndividualTicketPriceEndText(string customerInfo, int ticketPrice)
        {
            Console.WriteLine($"{customerInfo} {ticketPrice} SEK.");
            Console.WriteLine("");
            Console.WriteLine("Would you like to enter a new age, go back to the cinema menu or go to the main menu?");
            Console.WriteLine("1. New age.");
            Console.WriteLine("2. Go back to the cinema menu");
            Console.WriteLine("3. Go back to main menu");
        }

        public static void GroupCinemaMenuText()
        {
            Console.Clear();
            Console.WriteLine("You have come to the GroupCinemaMenu");
            Console.WriteLine("Enter the ages of the group members.");
            Console.WriteLine("Enter 'C' to calculate the price and see the group members' ages");
            Console.WriteLine("Enter 'B' to go back to the cinema menu and 'M' to go to the main menu");
        }


    }
}
