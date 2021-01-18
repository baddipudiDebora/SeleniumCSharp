using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Keys = OpenQA.Selenium.Keys;
namespace NUnitTestProject1
{
    public class UnitTest1 : BaseClass
    {
        [Test]
        public static void myTest()
        {
            BaseClass.landingpageObj.clickOnHotels();
            BaseClass.hotelsearchpageobj.fillHotelDetails("Ooty");
        }

    }
}
