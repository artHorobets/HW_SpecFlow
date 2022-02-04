using OpenQA.Selenium;
using OpenQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SpecFlow
{
    internal class Driver
    {
        public static IWebDriver driver { get; set; }
    }

    internal class Chrome
    {
        public static IWebDriver chrome { get; set; }       
    }
}