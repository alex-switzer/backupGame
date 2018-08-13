using System;
using System.Collections.Generic;

namespace backupGame.command
{
    class IP_Trace : commands
    {
        public IP_Trace()
        {
            name = "IP-Trace";
            description = "Trace an IP";
        }

        public override string lantern(List<string> result)
        {
            Random rnd = new Random();

            if (result.Count == 2)
            {
                if (stringClassifier.getIP( result[1]))
                {
                    return "Pinging " + result[1] + "; Respone time " + rnd.Next(10, 100) + "ms";
                }
            }
            return "Use IP-Trace [IP]";
        }


    }
}
