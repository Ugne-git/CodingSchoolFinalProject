using System;
using System.Collections.Generic;
using System.Text;
using CodingSchoolFinalProject.Pages;
using NUnit.Framework;

namespace CodingSchoolFinalProject.Tests
{
    public class LoginTest :PARENTEST
    {
        private LoginPage _loginPage;

        [SetUp]
        public void InitiateLoginPage()
        {
            _loginPage = new LoginPage(Driver);
        }

        [Test]
        public void UserLoginTest()
        {
            _loginPage.ClickSignInButton();
        }
    }
}


