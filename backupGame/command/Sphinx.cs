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
            description = "This command is useful for cracking passwords!";
        }

        public override string lantern(List<string> result)
        {
            Random rnd = new Random();

            //array of possible responses
            string[] commandResponses = { "www.nsa.govt/ hack.php has been hacked! The password is: admin",
                "www.apple.com has been hacked through SQL Injection! Steve's password is: samsungsucks",
                "Mike Wazowski's password to his PC has been hacked! It is: disneygivesmemoneylol",
                "Steve from minecraft has been hacked, it had no password!",
                "www.ncqa.govt has been hacked! Free Excellence credits can be gained through the login of: admin:admin " };

           
            int responseIndex = rnd.Next(commandResponses.Length);
            return commandResponses[responseIndex];
            ;
        }


    }
}
