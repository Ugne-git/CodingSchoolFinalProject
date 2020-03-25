using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CodingSchoolFinalProject.Pages;
using CodingSchoolFinalProject.Values;
using NUnit.Framework;

namespace CodingSchoolFinalProject.Tests
{
    public class AddItemTest:PARENTEST
    {
        [SetUp]
        public void InitLogIn()
        {
            _homePage.ClickHomeSignInButton().Login(User.DummyUser);
        }

        [Test]
        public void ChooseItemAndAddItToCartTest()
        {
            _userPage
                .selectCategory(Category.Women)
                .AsssertSelectedCatIsVisible(Categories.WOMEN)
                .selectCategory(Category.Dresses)
                .AsssertSelectedCatIsVisible(Categories.DRESSES)
                .MoveToQuickView()
                .AssertProductContainerIsVisible()
                .ClickQuickView()
                .AssertBuyBlockIsVisible()
                .ClickAddToCart()
                .AssertItemIsAddedToCart("Product successfully added to your shopping cart");
        }

        [TearDown]
        public void LogOutAndBackToHome()
        {
            MakeScreenShotOnTestFail();
            _userPage.ClickContinueShopping().GoToUserCart().RemoveItemFromCart().ClickSignOutButton();
            Thread.Sleep(5000);
        }


    }
}
