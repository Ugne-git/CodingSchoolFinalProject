using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CodingSchoolFinalProject.Tests
{
    public class HomeTests : PARENTEST
    {
        [Test]
        public void SignInIsAvailableTest()
        {
            _homePage
                .ClickSignInButton()
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
