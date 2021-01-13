using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject1
{
    class SeleniumSetMethods
    {
        // Enter text
        public static void EnterText( string element , string value, PropertyType elementType)
        {
            if(elementType == PropertyType.Id)
            {
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == PropertyType.CssName)
            {
                 PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);
            }
            if (elementType == PropertyType.Name)
            {
                 PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            }
            if (elementType == PropertyType.Xpath)
            {
                 PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
            }
            
        }
        // click on button , link, radiobutton
        public static void click( string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                 PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == PropertyType.CssName)
            {
                 PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
            }
            if (elementType == PropertyType.Name)
            {
                 PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            }
            if (elementType == PropertyType.Xpath)
            {
                 PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
            }
            if (elementType == PropertyType.LinkText)
            {
                 PropertiesCollection.driver.FindElement(By.LinkText(element)).Click();
            }
        }
        // selecting value from Dropdown
        public static void selectFromDropdown(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                new SelectElement( PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementType == PropertyType.CssName)
            {
                new SelectElement( PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByText(value);
            }
            if (elementType == PropertyType.Name)
            {
                new SelectElement( PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            }
            if (elementType == PropertyType.Xpath)
            {
                new SelectElement( PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
            }
           
        }
    }
}
