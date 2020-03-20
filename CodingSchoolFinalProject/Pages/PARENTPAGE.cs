using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingSchoolFinalProject.Pages
{
    public abstract class PARENTPAGE
    {
        protected IWebDriver Driver;
        protected PARENTPAGE(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}

