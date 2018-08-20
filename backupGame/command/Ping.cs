using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupGame.command
{
    class Ping : commands
    {
        public Ping()
        {
            name = "Ping";
            description = "Find the response time to a specified IP";
        }

        public override void lantern(List<string> result)
        {
            Random rnd = new Random();

            if (result.Count == 2) // i.e. if the user entered the name of the command and some numbers to ping
            {
                if (stringClassifier.getIP(result[1]))
                {
                    Console.WriteLine( "Pinging " + result[1] + "; Respone time " + rnd.Next(10, 100) + "ms");
                }
            }
            else Console.WriteLine( "Use Ping [IP]");
        }


    }
}
