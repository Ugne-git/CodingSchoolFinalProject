using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace CodingSchoolFinalProject.Pages
{
    public class CartPage : PARENTPAGE
    {
        //variables
        private IWebElement CartTitleElement => Driver.FindElement(By.CssSelector("#cart_title"));
        private IWebElement DeleteItemElement => Driver.FindElement(By.CssSelector(".cart_quantity_delete"));
        private IWebElement CartIsEmptyAllertElement => Driver.FindElement(By.CssSelector("#center_column >p.alert"));

        //class constructor
        public CartPage(IWebDriver driver) : base(driver) { }


        //methods

        public CartPage AsserShopingCartSummaryIsVisible()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => CartTitleElement.Displayed);
            //atgal reikia uzdeti implicit wait :) 
            Assert.IsNotNull(CartTitleElement, "shopping cart title was not presented");
            return this;
        }

        public CartPage RemoveItemFromCart()
        {
            DeleteItemElement.Click();
            return this;
        }

        public CartPage AssertCartIsEmpty(string expText)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => CartIsEmptyAllertElement.Displayed);
            Assert.AreEqual(expText, CartIsEmptyAllertElement.Text, "no confirmation that item was added");
            return this;
        }
    }
}
