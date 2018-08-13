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
            name = "help";
            description = "Help you out, girl!";


        }

        public override string lantern(List<string> result)
        {



            return "I will help you latter";
        }

    }
}
