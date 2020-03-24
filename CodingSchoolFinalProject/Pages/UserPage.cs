using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using CodingSchoolFinalProject.Pages;
using CodingSchoolFinalProject.Values;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace CodingSchoolFinalProject.Pages
{
    public enum Category { Women, Dresses, TShirts }
    public class UserPage : PARENTPAGE
    {
        //page navigation variables
        private IWebElement MyAccountElement => Driver.FindElement(By.Id("my-account"));
        private IWebElement SignOutElement => Driver.FindElement(By.CssSelector(".logout"));
        //select category variables
        private IWebElement WomenCatElement => Driver.FindElement(By.CssSelector($"#block_top_menu ul.sf-menu > li > a[Title='Women']"));
        private IWebElement DressesCatElement => Driver.FindElement(By.CssSelector($"#block_top_menu ul.sf-menu > li > a[Title='Dresses']"));
        private IWebElement TshirtsElement => Driver.FindElement(By.CssSelector($"#block_top_menu ul.sf-menu > li > a[Title='T-shirts']"));
        private IWebElement CatElement => Driver.FindElement(By.CssSelector(".title_block"));
        //add item to cart variables
        private IWebElement AddToCartButtonElement => Driver.FindElement(By.CssSelector(".left-block"));

        private IWebElement element => Driver.FindElement(By.Id("informations_block_left_1"));

        private IWebElement element2 => Driver.FindElement(By.CssSelector(".right-block"));

        private IWebElement button => Driver.FindElement(By.Id("add_to_cart"));

        //class driver constructor
        public UserPage(IWebDriver driver) : base(driver)
        {
        }

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

        public UserPage selectCategory(Category category)
        {
            switch (category)
            {
                case Category.Women:
                    WomenCatElement.Click();
                    break;
                case Category.Dresses:
                    DressesCatElement.Click();
                    break;
                case Category.TShirts:
                    TshirtsElement.Click();
                    break;
            }
            return this;
        }

        public UserPage AsssertSelectedCatIsVisible(Categories expectedCat)
        {
            Assert.AreEqual(expectedCat.title, CatElement.Text);
            return this;
        }

        public UserPage ClickAddTocartButton()
        {

            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            //new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => element.Displayed);
            Thread.Sleep(5000);
            Actions actions = new Actions(Driver);
            actions.MoveToElement(element2).Perform();
            Thread.Sleep(5000);
            actions.MoveToElement(element2).Click().Perform();
            Thread.Sleep(5000);
            
            AddToCartButtonElement.Click();
            Thread.Sleep(5000);

            Assert.IsNotNull(button);

            return this;
        }

    }
}
