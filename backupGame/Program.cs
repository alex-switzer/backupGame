using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                string text = "Please enter a registered command! For a full list type 'help'";
                

                if (result.Count != 0)
                {
                    for (int i = 0; i < listOfCommands.Count; i++)
                    {
                        if (listOfCommands[i].name.ToLower() == result[0].ToLower())
                        {
                            if (listOfCommands[i].name == "Help")
                            {
                                listOfCommands[i].lantern(result, listOfCommands);
                            }
                            else
                            {
                                listOfCommands[i].lantern(result);

                            }


                        }
                        



                    }

                }

            }
        }
    }
}
