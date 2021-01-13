using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject1
{
    class CommonMethods
    {
        // Enter text
        public static void EnterText(string element , string value, string elementType)
        {
            if(elementType == "Id")
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == "Css")
            {
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);
            }
            if (elementType == "Name")
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            }
            if (elementType == "Xpath")
            {
                PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
            }
            
        }
        // click on button , link, radiobutton
        public static void click(string element, string elementType)
        {
            if (elementType == "Id")
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == "Css")
            {
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
            }
            if (elementType == "Name")
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            }
            if (elementType == "Xpath")
            {
                PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
            }
            if (elementType == "LinkText")
            {
                PropertiesCollection.driver.FindElement(By.LinkText(element)).Click();
            }
        }
        // selecting value from Dropdown
        public static void selectFromDropdown(string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementType == "Css")
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByText(value);
            }
            if (elementType == "Name")
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            }
            if (elementType == "Xpath")
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
            }
           
        }
    }
}
