using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject1
{
   public class SeleniumSetMethods
    {
        // Enter text
        public static void EnterText( IWebElement element , string value, PropertyType elementType)
        {
            if(elementType == PropertyType.Id)
            {
                element.SendKeys(value);
            }
            if (elementType == PropertyType.CssName)
            {
                 element.SendKeys(value);
            }
            if (elementType == PropertyType.Name)
            {
                 element.SendKeys(value);
            }
            if (elementType == PropertyType.Xpath)
            {
                 element.SendKeys(value);
            }
      
        }
        // click on button , link, radiobutton
        public static void click(IWebElement element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                 element.Click();
            }
            if (elementType == PropertyType.CssName)
            {
                element.Click();
            }
            if (elementType == PropertyType.Name)
            {
                 element.Click();
            }
            if (elementType == PropertyType.Xpath)
            {
                 element.Click();
            }
            if (elementType == PropertyType.LinkText)
            {
                 element.Click();
            }
        }
        // selecting value from Dropdown
        public static void selectFromDropdown(IWebElement element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                new SelectElement(element).SelectByText(value);
            }
            if (elementType == PropertyType.CssName)
            {
                new SelectElement(element).SelectByText(value);
            }
            if (elementType == PropertyType.Name)
            {
                new SelectElement(element).SelectByText(value);
            }
            if (elementType == PropertyType.Xpath)
            {
                new SelectElement(element).SelectByText(value);
            }
           
        }
    }
}
