//this is bringing in other namespaces and functions that we can use inside of this program
using System;
//C# is a typed language, so we need to define the type

//namespace is a container for classes and functions
//a class is used to create objects from
namespace NumberGuesser
{
    //main class
    class Program
    {
        //entry point method
        //void is the return type of this method
        //when we use static, we don't have instances
        static void Main(string[] args)
        {
            //string name = "Kasey Knudsen";
            //int age = 44;
            ////start here
            //Console.WriteLine("Hello " + name + " is " + age);
            ////placeholder for dynamic value. variables must be in the correct order
            //Console.WriteLine("{0} is {1}", name, age);

            //displays app info
            GetAppInfo();

            //asks user's name and greets
            GreetUser();
          

            Boolean playingGame = true;

            while (playingGame)
            {
                //Set correct number
                //int correctNumber = 7;
                //create a new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //user guesses num
                int guess = 0;

                Console.WriteLine("Guess a number between 1 & 10");

                //use a loop to guess num until it's correct
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();
                    //verify input is a number using try parse
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Enter a number, you idiot");

                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number. Try again");
                    }
                }
                PrintColorMessage(ConsoleColor.DarkGreen, "You got it!!!");

                //ask user if they want to play again
                Console.WriteLine("Play again? [Y or N] ");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N")
                
                {
                    Console.WriteLine("Ok, thanks for playing");
                    playingGame = false;
                }
            }
        }
        static void GetAppInfo()
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Kasey Knudsen";

            //change text color
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("{0}, {1}, {2}", appName, appVersion, appAuthor);

            //change text color back
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("What is your name?");

            //save user's name as a variable
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        //print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            
            //change text color
            Console.ForegroundColor = color;

            //tell user it's the right answer
            Console.WriteLine(message);

            //change text color back
            Console.ResetColor();
        }
    }
}



