using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OrangeCRM.Elements
{
    public class DriverInit
    {
        public static IWebDriver driver { get; set; }
    }
}
