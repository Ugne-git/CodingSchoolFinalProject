using System;
using System.Collections.Generic;
using System.Text;
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
                //.selectCategory(Category.Dresses)
                //.AsssertSelectedCatIsVisible(Categories.DRESSES)
                .selectCategory(Category.Dresses)
                .AsssertSelectedCatIsVisible(Categories.DRESSES)
                .ClickAddTocartButton();

        }

        [TearDown]
        public void LogOutAndBackToHome()
        {
            MakeScreenShotOnTestFail();
        }


    }
}
