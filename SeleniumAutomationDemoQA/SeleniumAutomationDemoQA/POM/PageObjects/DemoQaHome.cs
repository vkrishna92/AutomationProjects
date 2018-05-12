using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.POM.PageObjects
{
    class DemoQaHome
    {
        private IWebDriver driver;
        public DemoQaHome(IWebDriver dr)
        {
            driver = dr;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement pageHeading;

        [FindsBy(How = How.LinkText, Using = "Registration")]
        public IWebElement registration;



    }
}
