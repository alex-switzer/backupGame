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
            description = "Get off the screen.";


        }

        public override string lantern(List<string> result)
        {
            return "Clearing screen, Can take up to 10 days. Sorry. ;)";
        }

    }
}
