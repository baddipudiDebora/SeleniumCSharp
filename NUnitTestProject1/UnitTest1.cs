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
       
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", "C:/ Users / Deborah / Desktop / chromedriver.exe");
            
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.goibibo.com/");
            PropertiesCollection.driver.Manage().Window.Maximize();
            // setting implicit wait
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void Test1()
        {
            CommonMethods.click("//span[contains(text(),'Hotels')]", "Xpath");

            CommonMethods.EnterText("downshift-1-input", "Ooty", "Id");
            System.Threading.Thread.Sleep(1000);
            CommonMethods.EnterText("downshift-1-input", Keys.ArrowDown, "Id");
            CommonMethods.EnterText("downshift-1-input", Keys.Return, "Id");


            // enter the check in date
            IWebElement checkinDate = PropertiesCollection.driver.FindElement(By.XPath("//div[contains(text(),'Check-in')]"));
            checkinDate.Click();
            PropertiesCollection.driver.FindElement(By.XPath("// span[contains(text(),'29')]")).Click();

            // enter the check out date
            PropertiesCollection.driver.FindElement(By.XPath("//div[contains(text(),'Check-out')]")).Click();
            PropertiesCollection.driver.FindElement(By.XPath("// span[contains(text(),'30')]")).Click();


        }
        [TearDown]
        public void quit()
        {
            PropertiesCollection.driver.Quit();
        }
    }
}