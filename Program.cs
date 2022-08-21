using System;
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

        static void Main(string[] args)
        {
            bool play=true;
            string? quit;
            while(play){
                string? userInput;
                Console.Write("What do you choose?\n\n Rock/ Paper/ Scissors? ");
                userInput = Console.ReadLine();
                
                while (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Your option can't be empty! Select one option once more");
                    userInput = Console.ReadLine();
                }

                Console.WriteLine(string.Format("You have selected the option {0}",userInput));

                switch (typeof(systemInput).GetRandomEnumValue())
                {
                    case systemInput.Rock:
                    //systemInput = "Rock";
                    Console.WriteLine("Computer chose Rock");
                    if (userInput == "Rock"||userInput == "rock")
                    {
                        Console.WriteLine("\nIt is a draw");
                    }
                    else if(userInput == "Paper"||userInput == "paper")
                    {
                        Console.WriteLine("\nYou Win!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou Lose!");
                    }
                    break;
                case systemInput.Paper:
                    //systemInput = "Paper";
                    Console.WriteLine("Computer chose Paper");
                    if (userInput == "Rock"||userInput == "rock")
                    {
                        Console.WriteLine("\nYou Lose!");
                    }
                    else if (userInput == "Paper"||userInput == "paper")
                    {
                        Console.WriteLine("It is a draw");
                    }
                    else
                    {
                        Console.WriteLine("You win");
                    }
                    break;
                case systemInput.Scissors:
                    //systemInput = "Scissors";
                    Console.WriteLine("Computer chose Scissors");
                    if (userInput == "Rock"||userInput == "rock")
                    {
                        Console.WriteLine("\nYou Win!");
                    }
                    else if (userInput == "Paper"||userInput == "paper")
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
            quit= Console.ReadLine();
            if(quit=="yes"||quit=="Yes"){
                continue;
            }
            else if(quit=="no"||quit=="No"){
                play=false;
            }
            else{
                Console.WriteLine("invalid entry!\nQuiting...!");
                play=false;
            }
            }
        }
    }
}