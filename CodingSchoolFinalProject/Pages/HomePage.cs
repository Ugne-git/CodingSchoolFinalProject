using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CodingSchoolFinalProject.Pages
{
    public class HomePage : PARENTPAGE
    {
        //variables
        private IWebElement SignInButtonElement => Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a")); //surasti ir pakeisti į geresnį selectorių
        private IWebElement HomeSliderElement => Driver.FindElement(By.Id("homeslider"));
        
        //constructor
        public HomePage(IWebDriver driver) : base(driver) { }

        //methods
        public LoginPage ClickSignInButton()
        {
            SignInButtonElement.Click();
            return new LoginPage(Driver);
        }

        public HomePage AssertHomeSliderIsVisible()
        {
            Assert.IsNotNull(HomeSliderElement, "Kazkoks klaidos pranesimas");
            return this;
        }
    }
}
