using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupGame.command
{
    class Hack : commands
    {
        public Hack()
        {
            name = "Hack";
            description = "Hack a computer!";


        }

        public override void lantern(List<string> result)
        { 

            Console.WriteLine( "You stole $10! good job. (from a 60 year old)");
        }


    }
}
