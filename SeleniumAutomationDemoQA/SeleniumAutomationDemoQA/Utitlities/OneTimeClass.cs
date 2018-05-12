using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.Utitlities
{
    class OneTimeClass:DriverClass
    {
        [OneTimeSetUp]
        public void SetupConfig()
        {
            //driver = BrowserFactory.getInstance("chrome");
            //configuring reports
            //screenshot paths
            Console.WriteLine("OneTimeSetUp");

        }
        [OneTimeTearDown]
        public void TearDownConfig()
        {
            driver.Quit();
            //Email settings 
        }
    }
}
