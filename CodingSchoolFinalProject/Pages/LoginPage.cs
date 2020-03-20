using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace CodingSchoolFinalProject.Pages
{
    public class LoginPage :PARENTPAGE
    {
        private IWebElement SigninButtonElement =>
            Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));

        public LoginPage(IWebDriver driver) : base(driver) { }
    }
}
