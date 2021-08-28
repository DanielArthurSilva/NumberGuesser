using System;

//Namespace
namespace NumberGuesser
{   //Main Class
    class Program
    {   //Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();

            while (true)
            {
                //Init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        //set error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //Output success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You Guessed it!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Husser";
            string appVersion = "1.0.0";
            string appAuthor = "Daniel Silva";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app infor
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get User Input
            string inputName = Console.ReadLine();

            //Start to play a game
            Console.WriteLine("Hell0 {0}, let's play a game...", inputName);
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Output success message
            //change text color
            Console.ForegroundColor = color;

            //Write out app infor
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
