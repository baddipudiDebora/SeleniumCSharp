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
            CommonMethods.click("//span[contains(text(),'Hotels')]", PropertyType.Xpath);

            CommonMethods.EnterText("downshift-1-input", "Ooty", PropertyType.Id);
            System.Threading.Thread.Sleep(1000);
            CommonMethods.EnterText("downshift-1-input", Keys.ArrowDown, PropertyType.Id);
            CommonMethods.EnterText("downshift-1-input", Keys.Return, PropertyType.Id);


            // enter the check in date
            CommonMethods.click("//div[contains(text(),'Check-in')]",PropertyType.Xpath);
            CommonMethods.click("// span[contains(text(),'29')]", PropertyType.Xpath);
           

          /* // enter the check in date
            CommonMethods.click("//div[contains(text(),'Check-out')]", PropertyType.Xpath);
            System.Threading.Thread.Sleep(2000);
            CommonMethods.click("// span[contains(text(),'30')]", PropertyType.Xpath);
          */

        }
        [TearDown]
        public void quit()
        {
            PropertiesCollection.driver.Quit();
        }
    }
}