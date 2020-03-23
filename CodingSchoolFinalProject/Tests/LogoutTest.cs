using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CodingSchoolFinalProject.Tests
{
    public class LogoutTest:PARENTEST
    {
        [SetUp]
        public void InitLogIn()
        {
            _homePage.ClickHomeSignInButton().Login(User.DummyUser);
        }

        [Test]
        public void UserLogoutTest()
        {
            _userPage
                .ClickSignOutButton()
                .AssertSubmitLoginButtonIsVisible();
        }

        [TearDown]
        public void BackToHome()
        {
            MakeScreenShotOnTestFail();
            _loginPage.ClickYourLogo();
        }
    }
}
