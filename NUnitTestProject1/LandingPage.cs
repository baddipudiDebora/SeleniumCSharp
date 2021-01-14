using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
namespace NUnitTestProject1
{
    public class LandingPage
    {
        private IWebDriver driver;
        // constructor of Page Class

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // WebElements inilized without page factory
        private IWebElement Hotelslink => driver.FindElement(By.XPath("//span[contains(text(),'Hotels')]"));
   

        // method to click on the Hotels LInk
        public void clickOnHotels()
        {
            Hotelslink.Click();
        }
    }
}
