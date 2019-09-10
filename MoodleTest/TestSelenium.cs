using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace MoodleTest
{
    [TestClass]
    public class TestSelenium
    {
        static IWebDriver driver;


        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            driver = new ChromeDriver();

        }

        [TestMethod]
        public void TestChromeDriver()
        {
            driver.Navigate().GoToUrl("http://172.16.51.98/moodle/login");

            // Get the page elements
            var userNameField = driver.FindElement(By.Id("username"));
            var userPasswordField = driver.FindElement(By.Id("password"));
            //var loginButton = driver.FindElement(By.Id("//input[@value='Login']");

            // Type user name and password
            userNameField.SendKeys("admin");
            userPasswordField.SendKeys("Moodle@123");

            // and click the login button
            //loginButton.Click();



            //driverGC.Navigate().GoToUrl("http://www.google.com/");
            //driverGC.FindElement(By.Id("lst-ib")).SendKeys("Tapas Pal Codeguru");
            //driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }
    }
}