using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName,
        Xpath
    }

    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
      
    }
}
