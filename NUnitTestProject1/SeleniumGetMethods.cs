using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject1
{
    class SeleniumGetMethods
    { // get text from Text box
        public static string GetText(string element, string elementType)
        {
            if (elementType == "Id")
                return PropertiesCollection.driver.FindElement(By.Id(element)).Text;
            if (elementType == "Name")
                return PropertiesCollection.driver.FindElement(By.Name(element)).Text;
            if (elementType == "Css")
                return PropertiesCollection.driver.FindElement(By.CssSelector(element)).Text;
            if (elementType == "Xpath")
                return PropertiesCollection.driver.FindElement(By.XPath(element)).Text;
            else
                return String.Empty;
        }
        // get text from Dropdown
        public static string  GetTextFromDropDown(string element, string elementType)
        {
            if (elementType == "Id")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.ToString();
            if (elementType == "Name")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.ToString();
            if (elementType == "Css")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).AllSelectedOptions.ToString();
            if (elementType == "Xpath")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).AllSelectedOptions.ToString();
            else
                return String.Empty;
        }
    }
}
