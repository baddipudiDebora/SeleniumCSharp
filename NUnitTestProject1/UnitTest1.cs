using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Keys = OpenQA.Selenium.Keys;
namespace NUnitTestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", "C:/ Users / Deborah / Desktop / chromedriver.exe");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.goibibo.com/");
            driver.Manage().Window.Maximize();
            // setting implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void Test1()
        {
            CommonMethods.click(driver, "//span[contains(text(),'Hotels')]", "Xpath");

            CommonMethods.EnterText(driver, "downshift-1-input", "Ooty", "Id");
            CommonMethods.EnterText(driver, "downshift-1-input", Keys.ArrowDown, "Id");
            CommonMethods.EnterText(driver, "downshift-1-input", Keys.Return, "Id");


            // enter the check in date
            IWebElement checkinDate = driver.FindElement(By.XPath("//div[contains(text(),'Check-in')]"));
            checkinDate.Click();
            driver.FindElement(By.XPath("// span[contains(text(),'29')]")).Click();

            // enter the check out date
            driver.FindElement(By.XPath("//div[contains(text(),'Check-out')]")).Click();
            driver.FindElement(By.XPath("// span[contains(text(),'30')]")).Click();


        }
        [TearDown]
        public void quit()
        {
            driver.Quit();
        }
    }
}