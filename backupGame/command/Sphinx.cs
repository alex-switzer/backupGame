using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupGame.command
{
    class Sphinx : commands
    {
        public Sphinx()
        {
            name = "Sphinx";
            description = "Your fist hack!";


        }

        public override string lantern(List<string> result)
        {

            return "nsa.govt/hack.php has been hacked! The password is admin!";
        }


    }
}
