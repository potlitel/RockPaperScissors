namespace Hello_World
{
    static partial class Program
    {
        /// <summary>
        /// Enum for declaring valid values
        /// </summary>
        public enum SystemInput
        {
            Rock,
            Paper,
            Scissors
        }
        /// <summary>
        /// This function validate user input exist in the enum values
        /// </summary>
        /// <param name="HostName"></param>
        /// <returns></returns>
        static string ValidateUserInput(string HostName)
        {
            string? userInput;
            //Console.Clear();
            Console.Write(string.Format("Ready to play againt 🖥️ {0}: what do you choose?\n\n 🧱 Rock/ 🧻 Paper/ ✂️ Scissors? ", HostName));
            userInput = Console.ReadLine();
            //Boolean ReadyToPlay = false;
            while (string.IsNullOrEmpty(userInput))
            {
                //Console.Clear();
                Console.WriteLine("⚠️ Your option can't be empty! Select one valid option once more");
                userInput = Console.ReadLine();
            }
            if (Enum.IsDefined(typeof(SystemInput), userInput))
            {
                Console.WriteLine(string.Format("🤔 You have selected the option {0}", userInput));
            }
            else
            {
                Console.WriteLine(string.Format("⚠️ Invalid option {0}", userInput));
            }

            return userInput;
        }
        /// <summary>
        /// This function enables the output console to show emojies
        /// </summary>
        static void EnableEncodingUTF8()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("\xfeff"); // bom = byte order mark
        }
        /// <summary>
        /// This function perform something when the system input is Rock
        /// </summary>
        /// <param name="userInput"></param>
        static void SystemInputRock(string? userInput)
        {
            Console.WriteLine("🖥️ Computer chose 🧱 Rock");
            if (userInput == "Rock" || userInput == "rock")
            {
                Console.WriteLine("It is a draw 🤝👏🎉!");
            }
            else if (userInput == "Paper" || userInput == "paper")
            {
                Console.WriteLine("\nYou Win 🥇🎆🎉👋!");
            }
            else
            {
                Console.WriteLine("\nYou Lose 🤯😭!");
            }
        }
        /// <summary>
        /// This function perform something when the system input is Paper
        /// </summary>
        /// <param name="userInput"></param>
        static void SystemInputPaper(string? userInput)
        {
            Console.WriteLine("🖥️ Computer chose 🧻 Paper");
            if (userInput == "Rock" || userInput == "rock")
            {
                Console.WriteLine("\nYou Lose 🤯😭!");
            }
            else if (userInput == "Paper" || userInput == "paper")
            {
                Console.WriteLine("It is a draw 🤝👏🎉!");
            }
            else
            {
                Console.WriteLine("\nYou Win 🥇🎆🎉👋!");
            }
        }
        /// <summary>
        /// This function perform something when the system input is Scissors
        /// </summary>
        /// <param name="userInput"></param>
        static void SystemInputScissors(string? userInput)
        {
            Console.WriteLine("🖥️ Computer chose ✂️ Scissors");
            if (userInput == "Rock" || userInput == "rock")
            {
                Console.WriteLine("\nYou Win 🥇🎆🎉👋!");
            }
            else if (userInput == "Paper" || userInput == "paper")
            {
                Console.WriteLine("\nYou Lose 🤯😭!");
            }
            else
            {
                Console.WriteLine("It is a draw 🤝👏🎉!");
            }
        }
    }
}