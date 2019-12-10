using System;
using System.Collections.Generic;
using System.Text;

namespace AssessReview3
{
    class Riders
    {
        //public string property that can be used to hold a string value
        public string Stop { get; set; }

        //a constructor that takes in 1 parameter, and then sets the value of that parameter to the property
        public Riders(string stop)
        {
            Stop = stop;
        }
    }
}
