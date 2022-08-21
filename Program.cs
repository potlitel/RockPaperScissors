using System;
using System.Net;
using RockPaperScissors;

namespace Hello_World
{
    class Program
    {
        public enum systemInput
        {
            Rock,
            Paper,
            Scissors
        }

        static void enable()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("\xfeff"); // bom = byte order mark
        }
        static void Main(string[] args)
        {
            enable();
            bool play = true;
            string? quit;
            string HostName = Dns.GetHostName();
            while (play)
            {
                string? userInput;
                /*Console.Write("What do you choose?\n\n Rock/ Paper/ Scissors? ");
                userInput = Console.ReadLine();
                Boolean ReadyToPlay = false;
                while (string.IsNullOrEmpty(userInput) || !ReadyToPlay)
                {
                    Console.WriteLine("Your option can't be empty! Select one option once more");
                    userInput = Console.ReadLine();
                }*/

                //string etiqueta = Enum.IsDefined(typeof(systemInput), userInput) ? "\u263A You have selected the option" : "Invalid option {0}";
                /*if (Enum.IsDefined(typeof(systemInput), userInput)) {
                    Console.WriteLine(string.Format("\u263A You have selected the option {0}",userInput));
                }
                else{
                    Console.WriteLine(string.Format("Invalid option {0}",userInput));
                }*/

                do
                {
                    //Console.Clear();
                    Console.Write(string.Format("Ready to play againt {0}: what do you choose?\n\n Rock/ Paper/ Scissors? ", HostName));
                    userInput = Console.ReadLine();
                    //Boolean ReadyToPlay = false;
                    while (string.IsNullOrEmpty(userInput))
                    {
                        //Console.Clear();
                        Console.WriteLine("🌟 Your option can't be empty! Select one option once more");
                        userInput = Console.ReadLine();
                    }
                    if (Enum.IsDefined(typeof(systemInput), userInput))
                    {
                        Console.WriteLine(string.Format("\u263A You have selected the option {0}", userInput));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Invalid option {0}", userInput));
                    }
                }
                while (!Enum.IsDefined(typeof(systemInput), userInput));

                String unicodeString = "Sailboats: ⛵~\u26f5" +
                    "\n" +  // or \r
                    "\x043a\x043e\x0448\x043a\x0430 \x65e5\x672c\x56fd\U00002728⏰\u25a3\u06de\u02a5\u0414\u0416\u0489\u8966";

                Console.WriteLine(unicodeString);

                switch (typeof(systemInput).GetRandomEnumValue())
                {
                    case systemInput.Rock:
                        Console.WriteLine("Computer chose Rock");
                        if (userInput == "Rock" || userInput == "rock")
                        {
                            Console.WriteLine("\nIt is a draw");
                        }
                        else if (userInput == "Paper" || userInput == "paper")
                        {
                            Console.WriteLine("\nYou Win!");
                        }
                        else
                        {
                            Console.WriteLine("\nYou Lose!");
                        }
                        break;
                    case systemInput.Paper:
                        Console.WriteLine("Computer chose Paper");
                        if (userInput == "Rock" || userInput == "rock")
                        {
                            Console.WriteLine("\nYou Lose!");
                        }
                        else if (userInput == "Paper" || userInput == "paper")
                        {
                            Console.WriteLine("It is a draw");
                        }
                        else
                        {
                            Console.WriteLine("You win");
                        }
                        break;
                    case systemInput.Scissors:
                        Console.WriteLine("Computer chose Scissors");
                        if (userInput == "Rock" || userInput == "rock")
                        {
                            Console.WriteLine("\nYou Win!");
                        }
                        else if (userInput == "Paper" || userInput == "paper")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            Console.WriteLine("It is a draw");
                        }
                        break;
                    default:
                        Console.WriteLine("invalid entry!");
                        break;
                }
                Console.WriteLine("\nDo you want to play again?  ");
                quit = Console.ReadLine();
                if (quit == "yes" || quit == "Yes")
                {
                    continue;
                }
                else if (quit == "no" || quit == "No")
                {
                    play = false;
                }
                else
                {
                    Console.WriteLine("invalid entry!\nQuiting...!");
                    play = false;
                }
            }
        }
    }
}