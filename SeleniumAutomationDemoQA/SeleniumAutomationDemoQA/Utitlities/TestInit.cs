using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.Utitlities
{
    class TestInit:DriverClass
    {
        /// <summary>
        /// This method handles login functionality for the application
        /// </summary>
        public static void loginManager()
        {
            driver.Url = "http://demoqa.com/";
            driver.Manage().Window.Maximize();
            //handle login here 
            //Enter user credentials and Login 

        }
    }
}
