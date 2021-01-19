using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public class HotelSearchPage
    {
        private IWebDriver driver;

       public HotelSearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement placeName => driver.FindElement(By.Id("downshift-1-input"));
        private IWebElement checkInButton => driver.FindElement(By.XPath("//div[contains(text(),'Check-in')]"));
        private IWebElement checkInDate => driver.FindElement(By.XPath("// span[contains(text(),'25')]"));
        public void fillHotelDetails(string hotelname)
        {
            SeleniumSetMethods.EnterText(placeName, "Ooty", PropertyType.Id);

            System.Threading.Thread.Sleep(1000);
            SeleniumSetMethods.EnterText(placeName, Keys.ArrowDown, PropertyType.Id);
            SeleniumSetMethods.EnterText(placeName, Keys.Return, PropertyType.Id);


            // enter the check in date
            SeleniumSetMethods.click(checkInButton, PropertyType.Xpath);
            SeleniumSetMethods.click(checkInDate, PropertyType.Xpath);


            /*// enter the check in date
            SeleniumSetMethods.click("//div[contains(text(),'Check-out')]", PropertyType.Xpath);

            SeleniumSetMethods.click("// span[contains(text(),'29')]", PropertyType.Xpath);*/

        }
    }
}
