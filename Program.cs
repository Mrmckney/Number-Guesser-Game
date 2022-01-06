namespace MattApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            AppInfo();

            PrintConsoleInfo(ConsoleColor.White, "What should I call you?");

            string? inputName = Console.ReadLine();

            if(inputName == "Matt" || inputName == "Matthew" || inputName == "matt" || inputName == "matthew")
            {

                CreatorGame();
                
            } 
            else if(inputName == "Color" || inputName == "color")
            {

                ColorGame();

            }
            else if(inputName == "Play" || inputName == "play")
            {

                EverythingIsRight();

            }
            else
            {

                UserGame(inputName);
                
            }

        }
         
        public static void AppInfo() 
        {

            string author = "Matt McKney";

            string title = "Number guesser";

            string version = "1.0.0";

            PrintConsoleInfo(ConsoleColor.DarkCyan, $"Made by {author} game is {title} version {version}");

        }

        public static void PrintConsoleInfo(ConsoleColor color, string message) 
        {

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();

        }

        public static void CreatorGame() 
        {
            
            PrintConsoleInfo(ConsoleColor.White, $"Oh Hey Boss, I'll make it easy for you :)");

            while(true)
            {

                Random rand = new Random();

                int correctNum0 = rand.Next(1,10);

                int guess0 = 0;

                PrintConsoleInfo(ConsoleColor.White, $"Guess my number 1 to 10");

                while (guess0 != correctNum0) 
                {

                    string? inputNum0 = Console.ReadLine();

                    if(!int.TryParse(inputNum0, out guess0)) 
                    {

                        PrintConsoleInfo(ConsoleColor.Yellow, "Please enter a number Boss");

                        continue;

                    }

                    guess0 = Int32.Parse(inputNum0);

                    if(guess0 > 10) 
                    {

                        PrintConsoleInfo(ConsoleColor.Yellow, $"Remember Boss the Max num is 10");

                    }

                    if(guess0 <= 0) 
                    {

                        PrintConsoleInfo(ConsoleColor.Yellow, "Remember Boss the Min num is 1");

                    }

                    string helper0 = "";

                    if(guess0 > correctNum0) 
                    {

                        helper0 = "Lower";

                    }

                    if(guess0 < correctNum0) 
                    {

                        helper0 = "Higher";

                    }

                    if(helper0 != "") 
                    {

                        PrintConsoleInfo(ConsoleColor.Red, $"Wrong number sorry Boss, Try {helper0}");
                        
                    }

                }
                
                PrintConsoleInfo(ConsoleColor.Green, "Correct way to go Boss!");

                PrintConsoleInfo(ConsoleColor.White, "Wanna Play Again Boss? [Y / N]");

                string? answer0 = Console.ReadLine()?.ToUpper();

                if(answer0 == "Y") 
                {

                    continue;

                } 
                else if(answer0 == "N") 
                {

                    PrintConsoleInfo(ConsoleColor.White, "Have a good day Boss!");

                    return;

                }
            }
        }

        public static void UserGame(string? inputName) 
        {

            PrintConsoleInfo(ConsoleColor.White, $"Well Hello {inputName}, Wanna play a game? [Y / N]");

            string? input = Console.ReadLine()?.ToUpper();

            if(input is "Y") 
            {

                while(true) 
                {

                    Random rand = new Random();

                    int randomMaxNum = rand.Next(20,100);

                    int numberOfGuesses = 10;

                    PrintConsoleInfo(ConsoleColor.White, $"Guess my number 1 to {randomMaxNum}");

                    PrintConsoleInfo(ConsoleColor.Blue, $"Number of guesses left {numberOfGuesses}");

                    Random random = new Random();

                    int correctNum = random.Next(1, randomMaxNum); 

                    int guess = 0;

                    while (guess != correctNum && numberOfGuesses > 0) 
                    {

                        string? inputNum = Console.ReadLine();

                        if(!int.TryParse(inputNum, out guess)) 
                        {

                            PrintConsoleInfo(ConsoleColor.Yellow, "Please enter a number");

                            continue;

                        }

                        guess = Int32.Parse(inputNum);

                        if(guess > randomMaxNum) 
                        {

                            PrintConsoleInfo(ConsoleColor.Yellow, $"Remember the Max num is {randomMaxNum}");

                            PrintConsoleInfo(ConsoleColor.Blue, $"You still have {numberOfGuesses} guesses left");

                        }

                        if(guess <= 0) 
                        {

                            PrintConsoleInfo(ConsoleColor.Yellow, $"Remember the Min num is 1");

                            PrintConsoleInfo(ConsoleColor.Blue, $"You still have {numberOfGuesses} guesses left");

                        }

                        string helper = "";

                        if(guess > correctNum && guess <= randomMaxNum && guess > 0)
                        {

                            helper = "Lower";
                            numberOfGuesses = numberOfGuesses - 1;

                        }

                        if(guess < correctNum && guess <= randomMaxNum && guess > 0) 
                        {

                            helper = "Higher";
                            numberOfGuesses = numberOfGuesses - 1;
                        }

                        if(helper is not "") 
                        {

                            PrintConsoleInfo(ConsoleColor.Red, $"Wrong number, Try {helper}");

                            PrintConsoleInfo(ConsoleColor.Blue, $"Number of guesses left {numberOfGuesses}");

                        }

                    }

                    if(numberOfGuesses <= 0)
                    {

                        PrintConsoleInfo(ConsoleColor.Red, $"Sorry {inputName} you ran out of guesses. Better luck next time!");

                        PrintConsoleInfo(ConsoleColor.White, "Wanna Try Again? [Y / N]");

                    }
                    else
                    {

                        PrintConsoleInfo(ConsoleColor.Green, $"Correct {inputName}!");

                        PrintConsoleInfo(ConsoleColor.Blue, $"You did it with {numberOfGuesses - 1} guesses remaining");

                        PrintConsoleInfo(ConsoleColor.White, "Wanna Play Again? [Y / N]");

                    }

                    string? answer = Console.ReadLine()?.ToUpper();

                    if(answer is "Y") 
                    {

                        continue;

                    } 
                    else if(answer is "N") 
                    {
                                
                        PrintConsoleInfo(ConsoleColor.White, $"Farewell {inputName}, Thanks for playing :)");

                        return;

                    }

                }

            }
            else
            {

                PrintConsoleInfo(ConsoleColor.White, $"Get lost then {inputName}");

            }
            
        }

        public static void EverythingIsRight() 
        {
            
            PrintConsoleInfo(ConsoleColor.White, $"Try if you dare");

            while(true)
            {

                int guess0 = 0;

                PrintConsoleInfo(ConsoleColor.White, $"Guess my number 1 to 1000");

                string? inputNum0 = Console.ReadLine();
            
                if(!int.TryParse(inputNum0, out guess0)) 
                {

                    PrintConsoleInfo(ConsoleColor.Yellow, "Please enter a number");

                    continue;

                }

                guess0 = Int32.Parse(inputNum0);

                if(guess0 < 0)
                {

                    PrintConsoleInfo(ConsoleColor.Yellow, $"Remember the Min num is 1");

                }

                if(guess0 > 1000)
                {

                    PrintConsoleInfo(ConsoleColor.Yellow, $"Remember the Max num is 1000");

                }
                
                if(guess0 > 0 && guess0 <= 1000) 
                {
                    PrintConsoleInfo(ConsoleColor.Green, "Correct!");

                    PrintConsoleInfo(ConsoleColor.White, "Wanna Play Again? [Y / N]");

                    string? answer0 = Console.ReadLine()?.ToUpper();

                    if(answer0 == "Y") 
                    {

                        continue;

                    } 
                    else if(answer0 == "N") 
                    {

                        PrintConsoleInfo(ConsoleColor.White, "Have a good day!");

                        return;

                    }

                }

            }
        }
        public static void ColorGame()
        {
           Console.WriteLine("Enter the color of your choice");

           Console.WriteLine("Black, Blue, Cyan, Gray, Green, Magenta, Red, White, Yellow, DarkBlue, DarkGray, DarkGreen, DarkMagenta, DarkRed, DarkYellow.");

           while(true)
           {

            string? colorInput = Console.ReadLine();

            if(colorInput is null)
            {

                return;
                
            }
            else
            {

                Console.ForegroundColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), colorInput);

                Console.WriteLine("Enter another color");

                Console.ResetColor();

            }
           }



        }

    }
}