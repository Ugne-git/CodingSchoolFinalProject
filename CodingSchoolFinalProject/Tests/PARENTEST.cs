using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingSchoolFinalProject.Tests
{
    public class PARENTEST
    {
        protected IWebDriver Driver;

        // driverio inicijavimas
        [SetUp]
        public void ParentPreconditions()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Url = "http://automationpractice.com/index.php";
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        //quitiname draiverį
        [TearDown]
        public void ParentPostconditions()
        {
            Driver.Quit();
        }
    }

}
