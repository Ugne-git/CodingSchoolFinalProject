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

namespace CodingSchoolFinalProject.Tests
{
    public class RemoveItemTest:PARENTEST
    {
        [SetUp]
        public void InitAddItemToCart()
        {
            _homePage
                .ClickHomeSignInButton()
                .Login(User.DummyUser)
                .AddItemToCartAndContinue().GoToUserCart();
        }

        [Test]
        public void RemoveItemFromCartTest()
        {
            _cartPage
                .AsserShopingCartSummaryIsVisible()
                .RemoveItemFromCart()
                .AssertCartIsEmpty("Your shopping cart is empty.");
      
        }

        [TearDown]
        public void SignOut()
        {
            MakeScreenShotOnTestFail();
            _userPage.ClickSignOutButton();
            Thread.Sleep(1000);
        }
    }
}
