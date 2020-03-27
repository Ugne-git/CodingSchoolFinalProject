using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CodingSchoolFinalProject.Pages
{
    public class LoginPage :PARENTPAGE
    {
        //variables
        private IWebElement SubmitLoginButtonElement => Driver.FindElement(By.Id("SubmitLogin"));
        private IWebElement YourLogoElement => Driver.FindElement(By.Id("header_logo"));
        private IWebElement EmailAddressElement => Driver.FindElement(By.Id("email"));
        private IWebElement PasswordElement => Driver.FindElement(By.Id("passwd"));
        private IWebElement SignInButtonElement => Driver.FindElement(By.Id("SubmitLogin"));

        //constructor
        public LoginPage(IWebDriver driver) : base(driver) { }

        //methods
        public LoginPage AssertSubmitLoginButtonIsVisible()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(15)).Until(d => SubmitLoginButtonElement.Displayed);
            Assert.IsNotNull(SubmitLoginButtonElement, "Login Button is not presented");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
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
            SignInButtonElement.Click();
            return new UserPage(Driver);
        }

        public UserPage Login(User user)
        {
            EnterUserEmail(user.UserEmail);
            EnterUserPassword(user.UserPassword);
            ClickSignInButton();
            return new UserPage(Driver);
        }


    }
}
