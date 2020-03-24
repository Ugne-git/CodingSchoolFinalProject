using System;
using System.Collections.Generic;
using System.Text;

namespace CodingSchoolFinalProject.Values
{
    public class Categories
    {
        public static Categories WOMEN = new Categories("WOMEN");
        public static Categories DRESSES = new Categories("DRESSES");
        public static Categories TSHIRTS = new Categories("CATALOG");

        public string title;

        public Categories(string title)
        {
            this.title = title;
        }
    }
}
