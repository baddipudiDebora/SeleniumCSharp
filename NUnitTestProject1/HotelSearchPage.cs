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

        public void fillHotelDetails(string hotelname)
        {
            SeleniumSetMethods.EnterText("downshift-1-input", "Ooty", PropertyType.Id);

            System.Threading.Thread.Sleep(1000);
            SeleniumSetMethods.EnterText("downshift-1-input", Keys.ArrowDown, PropertyType.Id);
            SeleniumSetMethods.EnterText("downshift-1-input", Keys.Return, PropertyType.Id);


            // enter the check in date
            SeleniumSetMethods.click("//div[contains(text(),'Check-in')]", PropertyType.Xpath);
            SeleniumSetMethods.click("// span[contains(text(),'20')]", PropertyType.Xpath);


            // enter the check in date
            CommonMethods.click("//div[contains(text(),'Check-out')]", PropertyType.Xpath);
            System.Threading.Thread.Sleep(2000);
            CommonMethods.click("// span[contains(text(),'28')]", PropertyType.Xpath);

        }
    }
}
