using System;

namespace CinemaMainMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<PurchaseSummary> listPurchaseSummary = new List<PurchaseSummary>();


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
                Console.WriteLine("3\t- Add a list of wishes \n");
                Console.WriteLine("4\t- Info about \n");



                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Your selection: \n");

                string userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    // See the price for a ticket
                    case "1":
                        bool continueSelect = true;
                        while (continueSelect)
                        {
                            var purchaseSummary = new PurchaseSummary();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nPlease enter your age: \n");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\nPress q to go to the Main Menu \n");
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
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Enter quantity: \n");
                                purchaseSummary.Quantity = int.Parse(Console.ReadLine());
                                purchaseSummary.PricePerTicket = 90;
                                Console.ResetColor();

                            }
                            else if (int.Parse(userAge) > 0 && int.Parse(userAge) < 20)
                            {

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\tPrice ticket: Student SEK 80\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Enter quantity: \n");
                                purchaseSummary.Quantity = int.Parse(Console.ReadLine());
                                purchaseSummary.PricePerTicket = 80;
                                Console.ResetColor();


                            }
                            else if ((int.Parse(userAge) < 64 && int.Parse(userAge) > 20))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\tPrice ticket: Ordinary SEK 120\n\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Enter quantity:\n");
                                purchaseSummary.Quantity = int.Parse(Console.ReadLine());
                                purchaseSummary.PricePerTicket = 120;
                                Console.ResetColor();

                            }
                            // Add price and quantity to the list
                            listPurchaseSummary.Add(purchaseSummary);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"Number of tickets: {purchaseSummary.Quantity}\tTotal Price: {purchaseSummary.TotalPrice} ");
                            Console.ResetColor();



                        }
                        continue;
                    case "2":
                        // Show total price and total nr of tickets
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"Number of tickets: {listPurchaseSummary.Sum(item => item.Quantity)}\nTotal Price: {listPurchaseSummary.Sum(item => item.TotalPrice)} ");
                        Console.ResetColor();
                        continue;
                    case "3":
                        bool continueWishList = true;
                        List<string> wishList = new List<string>();

                        while (continueWishList)
                        {

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Enter your words that are your wishes, Maxim 10 words: \n");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\nPress 0 to go to the Main Menu \n");
                            Console.ResetColor();

                            string wish = Console.ReadLine().ToLower();

                            wishList.Add(wish);

                            if (wish == "0")
                            {
                                continueWishList = false;
                            }
                        }
                        for(int s = 0; s < wishList.Count && s<=11; s++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"{s+1}.{wishList[s]},");
                            Console.ResetColor();
                        }

                        continue;
                    case "4":
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid selection. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
            while(continueProgram);
            Console.WriteLine("Thanks for using the application");


        }
    }
}
