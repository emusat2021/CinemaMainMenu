using System;

namespace CinemaMainMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********************************");
            Console.WriteLine("Welcome to the Cinema Main Menu!");
            Console.WriteLine("**********************************");
            Console.ForegroundColor= ConsoleColor.White;


            bool continueProgram = true;


            do
            {
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("--------------------------------\n");
                Console.WriteLine("Select an action from the Main Menu!\n");
                Console.WriteLine("--------------------------------\n");

                Console.WriteLine("0\t- EXIT the program");
                Console.WriteLine("1\t- See the price for a ticket");
                Console.WriteLine("2\t- Calculate total price for all chosen tickets\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Your selection: \n");

                string userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        bool continueSelect = true;
                        while (continueSelect)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nPlease enter your age: \n");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\nPress q to go to the Main Menu or Enter to continue\n");
                            Console.ResetColor();

                            string userAge = Console.ReadLine().ToLower();

                            if (userAge == "q")
                            {
                                continueSelect = false;
                            }
                            else if (int.Parse(userAge) > 64)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\tPrice ticket: Pensioner SEK 90 \n\n");
                                Console.WriteLine("Enter quantity: \n");
                                Console.ResetColor();
                                Console.ReadLine();
                            }
                            else if (int.Parse(userAge) > 0 && int.Parse(userAge) < 20)
                            {

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Price ticket: Student SEK 80");
                                Console.WriteLine("Enter quantity: \n");
                                Console.ResetColor();
                                Console.ReadLine();

                            }
                            else if ((int.Parse(userAge) < 64 && int.Parse(userAge) > 20))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Price ticket: Ordinary SEK 120");
                                Console.WriteLine("Enter quantity:\n");
                                Console.ResetColor();
                                Console.ReadLine();

                            }
                        }
                            continue;
                        case "2":
                            
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                }
            }
            while(continueProgram);
            Console.WriteLine("Thanks for using the application");


        }
    }
}
