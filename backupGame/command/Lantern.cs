using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupGame.command
{
    class Lantern : commands
    {
        public Lantern()
        {
            name = "Lantern";
            description = "Run it now!";


        }

        public override string lantern(List<string> result)
        {
            return "Get hacked kid!";
        }

    }
}
