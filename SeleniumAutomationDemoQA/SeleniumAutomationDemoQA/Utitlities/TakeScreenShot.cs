using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.Utitlities
{
    class TakeScreenShot:DriverClass
    {
        public static void takeScreenshot()
        {
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            ITakesScreenshot scrDriver = (ITakesScreenshot)driver;
            Screenshot screen = scrDriver.GetScreenshot();
            screen.SaveAsFile(@"C:\Users\vkris\Desktop\SeleniumScreenshot.png", ScreenshotImageFormat.Png);            
        }

        public void createdScreenshotFolder()
        {

        }
    }
}
