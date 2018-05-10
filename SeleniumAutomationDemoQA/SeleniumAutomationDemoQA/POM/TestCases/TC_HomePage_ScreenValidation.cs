using NUnit.Framework;
using SeleniumAutomationDemoQA.POM.PageObjects;
using SeleniumAutomationDemoQA.Utitlities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.POM.TestCases
{
    class TC_HomePage_ScreenValidation:TestBase
    {
        [Test]
        public void ValidateHomePageScreen()
        {
            DemoQaHome hm = new DemoQaHome(driver);
            
        }

    }
}
