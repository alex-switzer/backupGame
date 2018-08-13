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
            description = "Ping your girl.";


        }

        public override string lantern(List<string> result)
        {
            Random rnd = new Random();

            if (result.Count == 2)
            {
                if (stringClassifier.getIP(result[1]))
                {
                    return "Pinging " + result[1] + "; Respone time " + rnd.Next(10, 100) + "ms";
                }
            }
            return "Use Ping [IP]";
        }


    }
}
