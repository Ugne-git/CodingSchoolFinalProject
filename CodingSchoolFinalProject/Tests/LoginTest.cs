using System;
using System.Collections.Generic;
using System.Text;
using CodingSchoolFinalProject.Pages;
using NUnit.Framework;

namespace CodingSchoolFinalProject.Tests
{
    public class LoginTest :PARENTEST
    {
        [SetUp]
        public void InitSignIn()
        {
            _homePage
                .ClickHomeSignInButton();
        }

        [Test]
        public void UserLoginTest()
        {
            _loginPage
                .Login(User.DummyUser)
                .AssertMyAccountElementIsVisible();
        }

        [TearDown]
        public void LogOut()
        {
            MakeScreenShotOnTestFail();
            _userPage
                .ClickSignOutButton()
                .ClickYourLogo();
        }
    }
}


