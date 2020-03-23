using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CodingSchoolFinalProject.Tests
{
    public class HomeTest : PARENTEST
    {
        [Test]
        public void GoToSignInPageAndBackTest()
        {
            _homePage
                .ClickHomeSignInButton()
                .AssertSubmitLoginButtonIsVisible()
                .ClickYourLogo()
                .AssertHomeSliderIsVisible();

        }

        [TearDown]
        public void EndHome()
        {
            MakeScreenShotOnTestFail();
            //_loginPage.ClickYourLogo();
        }
    }
}
