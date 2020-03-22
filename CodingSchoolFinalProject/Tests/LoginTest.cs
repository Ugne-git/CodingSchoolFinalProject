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

        [TearDown]
        public void LogOut()
        {
            MakeScreenShotOnTestFail();
        }
    }
}


