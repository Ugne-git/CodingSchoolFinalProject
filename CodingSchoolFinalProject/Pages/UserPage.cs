﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CodingSchoolFinalProject.Pages
{
    public class UserPage:PARENTPAGE
    {
        //variables
        private IWebElement MyAccountElement => Driver.FindElement(By.Id("my-account"));
        private IWebElement SignOutElement => Driver.FindElement(By.CssSelector(".logout"));

        //constructor
        public UserPage(IWebDriver driver) : base(driver) { }

        //methods
        public UserPage AssertMyAccountElementIsVisible()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(15)).Until(d => MyAccountElement.Displayed);
            Assert.IsNotNull(MyAccountElement, "Kazkoks klaidos pranesimas");
            return this;
        }

        public LoginPage ClickSignOutButton()
        {
            SignOutElement.Click();
            return new LoginPage(Driver);
        }
    }
}