using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumAutomationDemoQA.Utitlities
{
    class FileUpload : DriverClass
    {
        public static void UploadFile(IWebElement element,string filePath)
        {
            //Move to the element first
            ((IJavaScriptExecutor)driver).ExecuteScript(
           "arguments[0].scrollIntoView();",element );
            //Click on the upload element
            element.Click();
            //Send keys
            SendKeys.SendWait(@filePath);
            Thread.Sleep(2000);
            SendKeys.SendWait(@"{Enter}");
        }
    }
}
