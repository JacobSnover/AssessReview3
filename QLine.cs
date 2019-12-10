using System;
using System.Collections.Generic;
using System.Text;

namespace AssessReview3
{
    class QLine
    {
        //List of Riders, that allows us to to carry passengers
        public List<Riders> Passengers = new List<Riders>();

        //use this string property to hold value of currentCondition
        public string CurrentCondition { get; set; }

        //constructor that takes in zero parameters
        //and initialize the CurrentCondition property to a default value
        public QLine()
        {
            CurrentCondition = "Running";
        }

        //we use this method to check the condition of the QLine
        public string Condition()
        {
            //check for the conditions that need to be met
            //and return the corresponding message
            if(Passengers.Count < 20)
            {
                CurrentCondition = "Running";
            }
            else if(Passengers.Count > 20)
            {
                CurrentCondition = "Too Many Riders";
            }

            return CurrentCondition;
        }
    }
}
