using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupGame.command
{
    class Lantern : commands
    {
        public Lantern() //purpose of this command is unclear
        {
            name = "Lantern";
            description = "Run it now!";


        }

        public override void lantern(List<string> result)
        {
            Console.WriteLine( "Get hacked kid!");
        }

    }
}
