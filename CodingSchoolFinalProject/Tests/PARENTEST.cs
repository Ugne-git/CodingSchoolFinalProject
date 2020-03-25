using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CodingSchoolFinalProject.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

namespace CodingSchoolFinalProject.Tests
{
    public class PARENTEST
    {
        protected IWebDriver Driver;
        protected LoginPage _loginPage;
        protected HomePage _homePage;
        protected UserPage _userPage;
        protected CartPage _cartPage;

        // driverio inicijavimas
        [SetUp]
        public void ParentPreconditions()
        {
            Driver = MainDriver.InitiateWebDriver(Browser.Chrome);
            Driver.Url = "http://automationpractice.com/index.php";

            InitiatePages();
        }

        //methods
        public void InitiatePages()
        {
            _loginPage = new LoginPage(Driver);
            _homePage = new HomePage(Driver);
            _userPage = new UserPage(Driver);
            _cartPage = new CartPage(Driver);
        }

        protected void CreateScreenshot()
        {
            Screenshot screenshot = Driver.TakeScreenshot();
            var screenshotpath = $"{TestContext.CurrentContext.WorkDirectory}/Screenshots";
            Directory.CreateDirectory(screenshotpath);
            string screenshotFile = Path.Combine(screenshotpath, $"{TestContext.CurrentContext.Test.Name}.png");
            screenshot.SaveAsFile(screenshotFile, ScreenshotImageFormat.Png);
            Console.WriteLine("screenshotFile: file://" + screenshotFile);

            TestContext.AddTestAttachment(screenshotFile, "My Screenshot");
        }

        protected void MakeScreenShotOnTestFail()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
            {
                CreateScreenshot();
            }
        }

        //klasės teardown'as - quitiname draiverį
        [TearDown]
        public void ParentPostconditions()
        {
            Driver.Quit();
        }
    }

}
