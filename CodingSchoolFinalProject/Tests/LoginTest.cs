using System;
using System.Collections.Generic;
using System.Text;
using CodingSchoolFinalProject.Pages;
using NUnit.Framework;

namespace CodingSchoolFinalProject.Tests
{
    public class LoginTest :PARENTEST
    {
        
        [Test]
        public void UserLoginTest()
        {
            _loginPage.ClickSignInButton();
        }

        [TearDown]
        public void LogOut()
        {
            MakeScreenShotOnTestFail();
        }
    }
}


