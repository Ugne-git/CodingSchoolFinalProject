using System;
using System.Collections.Generic;
using System.Text;

namespace CodingSchoolFinalProject.Values
{
    public class Title
    {
        public static Title WOMEN = new Title("Women");
        public static Title DRESSES = new Title("Dresses");

        //public static State FLORIDA = new State("Florida", 1);
        //public static State NEWJERSEY = new State("New Jersey", 2);
        //public static State NEWYORK = new State("New York", 3);
        //public static State OHIO = new State("Ohio", 4);
        //public static State TEXAS = new State("Texas", 5);
        //public static State PENNSYLVANIA = new State("Pennsylvania", 6);
        //public static State WASHINGTON = new State("Washington", 7);

        public string title;

        public Title(string title)
        {
            this.title = title;
        }
    }
}
