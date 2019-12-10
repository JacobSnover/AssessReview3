using System;
using System.Collections.Generic;

namespace AssessReview3
{
    class Program
    {
        static void Main(string[] args)
        {
            //use random class to create random number later
            Random rnd = new Random();

            //create a list for all the stops on the route
            List<string> stops = new List<string>()
            {
                "Congress",
                "Campus Martius",
                "Grand Circus",
                "Montcalm",
                "Sproat",
                "MLK/Mack",
                "Canfield",
                "Warren",
                "Ferry",
                "Amsterdam",
                "Grand Blvd"
            };

            //create a QLine object
            QLine qline = new QLine();

            //add enough passengers to make an error occur
            for (int i = 0; i < 21; i++)
            {
                //keep adding passnegers until error occurs
                qline.Passengers.Add(new Riders(stops[rnd.Next(0, stops.Count)]));

                //print the Condition of the QLine after each passenger is added
                Console.WriteLine((i + 1) + qline.Condition());                
            }

        }
    }
}
