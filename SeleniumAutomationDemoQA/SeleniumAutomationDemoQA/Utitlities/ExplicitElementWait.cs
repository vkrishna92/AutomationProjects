using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.Utitlities
{
    class ExplicitElementWait:DriverClass
    {
        private static WebDriverWait wait;
        private static void WebDriverWait()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        
        public static void ElementIsVisible(By elementObject)
        {
            WebDriverWait();
            wait.Until(ExpectedConditions.ElementIsVisible(elementObject));
        }
        public static void ElementExists(By elementObject)
        {
            WebDriverWait();
            wait.Until(ExpectedConditions.ElementExists(elementObject));            
        }
        public static void ElementToBeClickable(By elementObject)
        {
            WebDriverWait();
            wait.Until(ExpectedConditions.ElementToBeClickable(elementObject));
        }
        public static void ElementToBeClickable(IWebElement element)
        {
            WebDriverWait();
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void TextToBePresentInElement(IWebElement element, string element_text)
        {
            WebDriverWait();
            wait.Until(ExpectedConditions.TextToBePresentInElement(element,element_text));
        }
        public static void TextToBePresentInElementLocated(By elementObject,string element_text)
        {
            WebDriverWait();
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(elementObject,element_text));
        }
    }
}
