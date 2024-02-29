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
                Console.WriteLine("\"0\" - To Close the program" +
                    "\n");
            
                input = Console.ReadLine();

                switch(input)
                {
                    case "0":
                        Environment.Exit(0);
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
