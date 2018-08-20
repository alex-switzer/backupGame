using System;
using System.Collections.Generic;

namespace backupGame.command
{
    class IP_Trace : commands
    {
        public IP_Trace()
        {
            name = "IP-Trace";
            description = "Find out where an IP address is located in the real world!";
        }

        public override void lantern(List<string> result)
        {
            Random rnd = new Random();


            string[] countries = { "United States of America", "Zimbabwe", "Poland", "New Zealand", "Australia", "Switzerland", "Greenland", "Iceland", "Russia", "Syria" , "Niger", "Yemen"};


            if (result.Count == 2)
            {
                if (stringClassifier.getIP( result[1]))
                {
                    int countryIndex = rnd.Next(countries.Length); //pseudorandomly generate country index for array

                    Console.WriteLine("This person is likely from {0}!", countries[countryIndex]); }
            }

            else Console.WriteLine( "Use IP-Trace [IP]");
        }


    }
}
