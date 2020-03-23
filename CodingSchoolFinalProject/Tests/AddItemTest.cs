using System;
using System.Collections.Generic;
using System.Text;
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

            _userPage.ClickCat("Women").IsVisible();
        }

        [TearDown]
        public void LogOutAndBackToHome()
        {
            MakeScreenShotOnTestFail();
        }


    }
}
