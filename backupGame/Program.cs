using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Emulated interactive command line for Unity Hack Game
/// This will be the code for the console that should be found within the Graphical Unity Game


namespace backupGame
{
    class Program
    {

        static void Main(string[] args)
        {
            List<commands> listOfCommands = new List<commands>
            {
                new command.Help(),
                new command.Ping(),
                new command.Sphinx(),
                new command.Clear(),
                new command.Lantern(),
                new command.IP_Trace(),
                new command.Time(),
                new command.Hack()
            };

            while (true)
            {
                PrintPrefix(); //get coloured default text that appears before each command for realism

                string line = Console.ReadLine();

                List<string> userInputParamters = line.Split('"') //store all user input parameters
                     .Select((element, index) => index % 2 == 0  // If even index
                                           ? element.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)  // Split the item
                                           : new string[] { element })  // Keep the entire item
                     .SelectMany(element => element).ToList();

                string errorText = "Please enter a registered command, for a full list type 'help'"; //setting the default message to an error

                bool commandFound = false;


                string userCommand = userInputParamters[0].ToLower(); //first parameter is always the command name

                if (userInputParamters.Count != 0)
                {
                    for (int i = 0; i < listOfCommands.Count; i++)
                    {
                        string registeredCommand = listOfCommands[i].name.ToLower();

                        if (registeredCommand == userCommand)
                        {
                            listOfCommands[i].lantern(userInputParamters); //execute the matching command

                            if (registeredCommand == "help") listOfCommands[i].lantern(userInputParamters, listOfCommands);
                            commandFound = true; //matching command found, declare success
                        }

                    }
                }

                if (commandFound == false) Console.WriteLine(errorText); //if the user entered nothing, or something invalid, display an error

            }
        }

        public static void PrintPrefix()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("root@kali"); //make prefix coloured
            Console.ResetColor();
            Console.Write(":~# ");
        }
    }

}
