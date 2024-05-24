using System.Text.RegularExpressions;

/*
 * I denna klass bryter jag lite mot min konvention att försöka bara skapa variabler om de behövs.
 * Jag skapar groupCost och groupAges innan jag vet om de behövs.
 * Dock valde jag att ha det så här eftersom det fungerar och det har kraschat lite när jag har försökt göra om.
 *
 * Annars har jag försökt utforma denna applikation som de andra. Med en loop som körs tills den får korrekt input från användaren.
 */

namespace LoopFlowAndStringManipulation.CinemaApplication
{
    internal class CinemaGroup
    {
        public static void GroupCinemaMenu()
        {
            CinemaText.GroupCinemaMenuText();

            int groupCost = 0;
            List<int> groupAges = new List<int>();

            bool runMenu = true;
            while (runMenu)
            {
                string userInput = Console.ReadLine()!;

                bool isNumber = Regex.IsMatch(userInput, @"^\d+$");

                if (userInput.ToUpper().Equals("C"))
                {
                    // Om användaren försöker beräkna pris innan någon har lagts till i grupplistan så blir det ett felmeddelande och applikationen körs från början.
                    if (!groupAges.Any())
                    {
                        Console.WriteLine("There are no members in this group.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        runMenu = false;
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
                        // Jag är osäker på om det behövs men jag tömmer grupplistan och sätter kostnaden till noll igen.
                        groupAges.Clear();
                        groupCost = 0;
                        runMenu = false;
                        GroupCinemaMenu();
                    }
                }
                // Om input är ett nummer så uppdateras kostnaden och listan över gruppens åldrar.
                else if (isNumber)
                {
                    int customerAge = int.Parse(userInput);
                    groupCost += CinemaApp.CalculateTicketPrice(customerAge);
                    groupAges.Add(customerAge);
                }
                // Nedanför är de valen för att gå tillbaka till tidigare applikationer.
                else if (userInput.ToUpper().Equals("B"))
                {
                    runMenu = false;
                    CinemaApp.CinemaMainMenu();
                }
                else if (userInput.ToUpper().Equals("M"))
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
