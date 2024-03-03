namespace CinemaMainMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            string input = string.Empty;

            do
            {
                Console.WriteLine("Welcome to the Cinema's Main Menu!");
                Console.WriteLine("--------------------------------\n");
                Console.WriteLine("You have the folowing choices:\n");
                Console.WriteLine("0\t- EXIT the program");
                Console.WriteLine("1\t- Buy a ticket");
            
                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Console.WriteLine("Please enter your age: ");
                        int input2 = 0;
                        int.TryParse(Console.ReadLine(), out input2);
                        if(input2 > 64)
                        {
                            Console.WriteLine("Price ticket: Pensioner SEK 90");
                        }
                        else if(input2 < 20)
                        {
                            Console.WriteLine("Price ticket: Student SEK 80");
                        }
                        else
                        {
                            Console.WriteLine("Price ticket: Ordinary SEK 120");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }while(continueProgram);
            Console.WriteLine("Closing application");


        }
    }
}
