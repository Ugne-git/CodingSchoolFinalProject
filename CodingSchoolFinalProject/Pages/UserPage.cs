using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CodingSchoolFinalProject.Pages
{
    public class UserPage:PARENTPAGE
    {
        //variables
        private IWebElement MyAccountElement => Driver.FindElement(By.Id("my-account"));

        //constructor
        public UserPage(IWebDriver driver) : base(driver) { }

        //methods
        public UserPage AssertMyAccountElementIsVisible()
        {
            Assert.IsNotNull(MyAccountElement, "Kazkoks klaidos pranesimas");
            return this;
        }
    }
}
