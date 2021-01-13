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
            LandingPage landingpageObj = new LandingPage(PropertiesCollection.driver);
            landingpageObj.clickOnHotels();

            HotelSearchPage hotelsearchpageobj = new HotelSearchPage(PropertiesCollection.driver);
            hotelsearchpageobj.fillHotelDetails("Ooty");


        }
        [TearDown]
        public void quit()
        {
            PropertiesCollection.driver.Quit();
        }
    }
}