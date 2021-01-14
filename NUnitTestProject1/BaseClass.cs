using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Keys = OpenQA.Selenium.Keys;

namespace NUnitTestProject1
{
   public class BaseClass
    {
       public static LandingPage landingpageObj;
       public static  HotelSearchPage hotelsearchpageobj;
    public static void  setUp()
        
        {
   
        PropertiesCollection.driver = new ChromeDriver();
        System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", "C:/ Users / Deborah / Desktop / chromedriver.exe");

        PropertiesCollection.driver.Navigate().GoToUrl("https://www.goibibo.com/");
        PropertiesCollection.driver.Manage().Window.Maximize();
            // setting implicit wait
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            landingpageObj = new LandingPage(PropertiesCollection.driver);
            hotelsearchpageobj = new HotelSearchPage(PropertiesCollection.driver);
        }
    }
}
