using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CodingSchoolFinalProject
{
    public enum Browser { Firefox, Chrome}

    public static class MainDriver
    {
        public static IWebDriver InitiateWebDriver(Browser browser)
        {
            IWebDriver driver = null;
            switch (browser)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    break;
                case Browser.Firefox:
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    break;
                default:
                    Assert.Fail("Browser not supported");
                    break;
            }

            return driver;
        }
    }
}
