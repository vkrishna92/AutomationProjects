using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.Utitlities
{
    class BrowserFactory:DriverClass
    {
        /// <summary>
        /// returns instance of the desired browser
        /// </summary>
        /// <param name="browserName"></param>
        /// <returns></returns>
        public static IWebDriver getInstance(string browserName)
        {
            if (driver == null)
            {

                if(browserName.Contains("chrome"))
                {
                    driver = new ChromeDriver();
                }
                else if(browserName.Contains("firefox"))
                {
                    //firefox driver 
                }
                else
                {
                    driver = new ChromeDriver();
                }
            }
            return driver;
        }
        
    }
}
