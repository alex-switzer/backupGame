﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backupGame.command
{
    class Time : commands
    {
        public Time()
        {
            name = "Time";
            description = "Find out what the time is!";


        }

        public override string lantern(List<string> result)
        {



            return "The time is " + DateTime.UtcNow.ToLocalTime() + ".";
        }

    }
}
