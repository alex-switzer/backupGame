using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupGame.command
{
    class Clear : commands
    {
        public Clear()
        {
            name = "Clear";
            description = "Clear the screen of all text";


        }

        public override void lantern(List<string> result)
        {
            
            Console.Clear();
        }

    }
}
