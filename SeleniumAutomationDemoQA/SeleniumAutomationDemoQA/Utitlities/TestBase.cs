using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.Utitlities
{
    /// <summary>
    /// Implemented Singleton Pattern to get browser instance
    /// </summary>
    class TestBase:DriverClass
    {
        [SetUp]
        public void setup()
        {
            //Enter URL 
            TestInit.loginManager();
            

            
        }
        [TearDown]
        public void closure()
        {

        }
    }
}
