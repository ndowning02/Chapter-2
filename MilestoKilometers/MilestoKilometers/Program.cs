﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double KILO_TO_MILES = 1.6;
            double milesEntry = 5;
            double kilo;
            kilo = KILO_TO_MILES * milesEntry;
            Console.WriteLine("The number of miles entered was {0}, " +
                "and that equals {1} kilometerrs.", milesEntry, kilo);


        }

        public static void displayEnterActiveConversion()
        {
            const double KILO_TO_MILES = 1.6;
            double milesEntry = 5;
            double kilo;
            string milesEntryString;

            Console.WriteLine("Just enter some miles now!!! >>>> ");
            milesEntryString = Console.ReadLine();
            milesEntry = Convert.ToDouble(milesEntryString);

            kilo = KILO_TO_MILES * milesEntry;
            Console.WriteLine("The number of miles entered was {0}, " +
                "and that equals {1} kilometers.", milesEntry, kilo);




        }
    }
}
