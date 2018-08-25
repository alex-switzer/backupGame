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

        public override void lantern(List<string> result)
        {
            Random rnd = new Random();

            //array of possible responses
            string[] commandResponses = { "www.nsa.govt/ hack.php has been hacked! The password is: admin",
                "www.apple.com has been hacked through SQL Injection! Steve's password is: samsungsucks",
                "Mike Wazowski's password to his PC has been hacked! It is: disneymoney123",
                "Steve's account from minecraft has been hacked, it is: diamonds!",
                "www.nzqa.govt.nz has been hacked! Free Excellence credits can be gained through the login of: admin:admin " ,
                "You have hacked yourself! Your own very secure password is ZWFzdGVyIGVnZw=="};

           
            int responseIndex = rnd.Next(commandResponses.Length); //choose pseudorandom response from array
            Console.WriteLine(commandResponses[responseIndex]);
            ;
        }


    }
}
