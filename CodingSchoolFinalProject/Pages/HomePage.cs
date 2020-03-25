using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CodingSchoolFinalProject.Pages
{
    public class HomePage : PARENTPAGE
    {
        //variables
        private IWebElement HomeSignInButtonElement => Driver.FindElement(By.CssSelector(".login"));
        private IWebElement HomeSliderElement => Driver.FindElement(By.Id("homeslider"));
        
        //constructor
        public HomePage(IWebDriver driver) : base(driver) { }

        //methods
        public LoginPage ClickHomeSignInButton()
        {
            try
            {
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
                new WebDriverWait(Driver, TimeSpan.FromSeconds(15)).Until(d => HomeSignInButtonElement.Displayed);
                HomeSignInButtonElement.Click();
            }
            catch (WebDriverTimeoutException e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

            return new LoginPage(Driver);
        }

        public HomePage AssertHomeSliderIsVisible()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(15)).Until(d => HomeSliderElement.Displayed);
            Assert.IsNotNull(HomeSliderElement, "Home Slider is not presented");
            return this;
        }
    }
}
