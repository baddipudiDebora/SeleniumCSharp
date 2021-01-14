using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    public enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName,
        Xpath
    }

    public class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
      
    }
}
