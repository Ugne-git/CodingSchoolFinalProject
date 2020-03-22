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
        private IWebElement EmailAddressElement => Driver.FindElement(By.Id("email"));
        private IWebElement PasswordElement => Driver.FindElement(By.Id("passwd"));
        private IWebElement SignInButton => Driver.FindElement(By.Id("SubmitLogin"));

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

        public LoginPage EnterUserEmail(string useremail)
        {
            EmailAddressElement.SendKeys(useremail);
            return this;
        }

        public LoginPage EnterUserPassword(string password)
        {
            PasswordElement.SendKeys(password);
            return this;
        }

        public UserPage ClickSignInButton()
        {
            SignInButton.Click();
            return new UserPage(Driver);
        }


    }
}
