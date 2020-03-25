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
        private IWebElement ProductContainerElement => Driver.FindElement(By.CssSelector(".right-block"));
        private IWebElement QuickViewElement => Driver.FindElement(By.CssSelector(".left-block"));
        private IWebElement AddToCartButtonElement => Driver.FindElement(By.CssSelector("#add_to_cart button"));
        private IWebElement BuyBlockElement => Driver.FindElement(By.CssSelector("#buy_block"));
        private IWebElement CartBlockElement =>
            Driver.FindElement(By.CssSelector("#layer_cart div.clearfix div.layer_cart_product > h2"));

        //after adding item to cart variables
        private IWebElement ContinueShoppingElement => Driver.FindElement(By.CssSelector("#layer_cart div.clearfix div.layer_cart_cart div.button-container > span"));
        private IWebElement CartButtonElement => Driver.FindElement(By.CssSelector(".shopping_cart > a"));

        //class driver constructor
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
            Assert.AreEqual(expectedCat.title, CatElement.Text, "Kazkoks klaidos pranesimas");
            return this;
        }

        public UserPage MoveToQuickView()
        {

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => ProductContainerElement.Displayed);
            Actions actions = new Actions(Driver);
            actions.MoveToElement(ProductContainerElement).Perform();

            return this;
        }

        public UserPage AssertProductContainerIsVisible()
        {
            Assert.IsNotNull(QuickViewElement, "Kazkoks klaidos pranesimas");
            return this;
        }

        public UserPage ClickQuickView()
        {
            QuickViewElement.Click();
            return this;
        }

        public UserPage AssertBuyBlockIsVisible()
        {

            Driver.SwitchTo().Frame(0);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => BuyBlockElement.Displayed);
            Assert.IsNotNull(BuyBlockElement, "Kazkoks klaidos pranesimas");
            Driver.SwitchTo().DefaultContent();
            return this;
        }

        public UserPage ClickAddToCart()
        {
            Driver.SwitchTo().Frame(0);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => AddToCartButtonElement.Displayed);
            AddToCartButtonElement.Click();
            Driver.SwitchTo().DefaultContent();
            return this;
        }

        public UserPage AssertItemIsAddedToCart(string exptext)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => CartBlockElement.Displayed);
            Assert.AreEqual(exptext, CartBlockElement.Text, "Kazkoks klaidos pranesimas");
            return this;
        }

        public UserPage ClickContinueShopping()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => ContinueShoppingElement.Displayed);
            ContinueShoppingElement.Click();
            return this;
        }

        public UserPage AddItemToCartAndContinue()
        {
            selectCategory(Category.Dresses);
            MoveToQuickView();
            ClickQuickView();
            ClickAddToCart();
            ClickContinueShopping();
            return this;
        }

        public CartPage GoToUserCart()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => CartButtonElement.Displayed);
            Actions actions = new Actions(Driver);
            actions.MoveToElement(CartButtonElement).Click().Perform();
            return new CartPage(Driver);
        }

    }
}
