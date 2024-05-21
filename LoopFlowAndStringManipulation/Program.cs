namespace LoopFlowAndStringManipulation {
    internal class Program {
        static void Main(string[] args) {
            MainMenu();
        }

        static void MainMenu() {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the main menu.");
            Console.WriteLine("");
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
    }
}
