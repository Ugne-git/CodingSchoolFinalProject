using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CodingSchoolFinalProject.Pages
{
    public class LoginPage :PARENTPAGE
    {
        //variables
        private IWebElement SubmitLoginButtonElement => Driver.FindElement(By.Id("SubmitLogin"));
        private IWebElement YourLogoElement => Driver.FindElement(By.Id("header_logo"));

        //constructor
        public LoginPage(IWebDriver driver) : base(driver) { }

        //methods
        public LoginPage AssertSubmitLoginButtonIsVisible()
        {
            Assert.IsNotNull(SubmitLoginButtonElement, "Kazkoks klaidos pranesimas");
            return this;
        }

        public HomePage ClickYourLogo()
        {
            YourLogoElement.Click();
            return new HomePage(Driver);
        }


    }
}
