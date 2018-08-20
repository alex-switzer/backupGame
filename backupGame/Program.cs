using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Console for Hack Game
/// This will be the code for the console that should be found within the Graphical Unity Game


namespace backupGame
{
    class Program
    {

        static void Main(string[] args)
        {
            List<commands> listOfCommands = new List<commands>();

            listOfCommands.Add(new command.Help());
            listOfCommands.Add(new command.Ping());
            listOfCommands.Add(new command.Sphinx());
            listOfCommands.Add(new command.Clear());
            listOfCommands.Add(new command.Lantern());
            listOfCommands.Add(new command.IP_Trace());
            listOfCommands.Add(new command.Time());
            listOfCommands.Add(new command.Hack());

            while (true)
            {
                string line = Console.ReadLine();

                List<string> result = line.Split('"')
                     .Select((element, index) => index % 2 == 0  // If even index
                                           ? element.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)  // Split the item
                                           : new string[] { element })  // Keep the entire item
                     .SelectMany(element => element).ToList();

                string errorText = "Please enter a registered command, for a full list type 'help'"; //setting the default message to an error

                bool commandFound = false; //automatically assign failure

                if (result.Count != 0)
                {
                    for (int i = 0; i < listOfCommands.Count; i++)
                    {
                        string registeredCommand = listOfCommands[i].name.ToLower();
                        string userCommand = result[0].ToLower();

                        if (registeredCommand == userCommand)
                        {
                            listOfCommands[i].lantern(result); //execute the matching command

                            if (registeredCommand == "help") listOfCommands[i].lantern(result, listOfCommands);
                            commandFound = true; //matching command found, declare success
                        }

                    }
                }

                if (commandFound == false) Console.WriteLine(errorText); //if the user entered nothing, or their command wasn't found display error

            }
        }
    }
}
