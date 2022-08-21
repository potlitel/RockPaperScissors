using System;
using System.Net;
using RockPaperScissors;

namespace Hello_World
{
    static partial class Program
    {
        static void Main(string[] args)
        {
            EnableEncodingUTF8();
            bool play = true;
            string HostName = Dns.GetHostName();
            while (play)
            {
                string? userInput;
                do
                    userInput = ValidateUserInput(HostName);
                while (!Enum.IsDefined(typeof(SystemInput), userInput));

                switch (typeof(SystemInput).GetRandomEnumValue())
                {
                    case SystemInput.Rock:
                        SystemInputRock(userInput);
                        break;
                    case SystemInput.Paper:
                        SystemInputPaper(userInput);
                        break;
                    case SystemInput.Scissors:
                        SystemInputScissors(userInput);
                        break;
                    default:
                        Console.WriteLine("invalid entry!");
                        break;
                }
                Console.WriteLine("\n 📢 Do you want to play again?  ");
                string? quit = Console.ReadLine();
                switch (quit)
                {
                    case "yes" or "Yes":
                        continue;
                    case "no" or "No":
                        play = false;
                        break;
                    default:
                        Console.WriteLine(" ⚠️ Invalid entry!\n Quiting...!");
                        play = false;
                        break;
                }
            }
        }
    }
}