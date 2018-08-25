using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupGame.command
{
    class Help : commands
    {
        public Help()
        {
            name = "Help";
            description = "Learn about the purpose of each command.";
        }

        public override void lantern(List<string> result, List<commands> listOfCommands)
        {
            Console.WriteLine("\n" + "List of commands:" + "\n");
            const int paddingBuffer = 30; //default gap between command and description 
            
            foreach (var command in listOfCommands)
            {
                int paddingGap = paddingBuffer - command.name.Length;
                if (paddingGap < 0) paddingGap *= -1; //if the name is longer than the buffer of 30, avoid errors by avoiding negative numbers
                Console.WriteLine("Command: {0}" + "Description: {1}".PadLeft(paddingGap), command.name, command.description);
                
            }

        }

    }
}
