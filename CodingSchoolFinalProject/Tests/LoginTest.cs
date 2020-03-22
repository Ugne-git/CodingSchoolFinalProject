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
            _homePage.ClickSignInButton();
        }

        [Test]
        public void BackToHomePageIsAvailable()
        {
            _loginPage.ClickYourLogo().AssertHomeSliderIsVisible();
        }

        [Test]
        public void TestUserLogin()
        {
            _loginPage
                .EnterUserEmail(User.DummyUser.UserEmail)
                .EnterUserPassword(User.DummyUser.UserPassword)
                .ClickSignInButton()
                .AssertMyAccountElementIsVisible();
        }

        [TearDown]
        public void LogOut()
        {
            MakeScreenShotOnTestFail();
        }
    }
}


