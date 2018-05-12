using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAutomationDemoQA.POM.PageObjects;
using SeleniumAutomationDemoQA.Utitlities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.POM.TestCases
{
    class TC_Registration:TestBase
    {
        [Test]
        public void RegisterUser()
        {
            DemoQaHome hm = new DemoQaHome(driver);
            hm.registration.Click();
            ExplicitElementWait.ElementIsVisible(By.TagName("h1"));
            RegistrationPage register = new RegistrationPage(driver);
            //register.EnterFullName("Vamsi Krishna", "Gattupalli");
            //register.marital_Status("single");
            //register.check_hobby("reading");
            //register.Select_country("India");
            //register.selectDateofBirth("6", "17", "1992");
            //register.EnterPhoneNumber("2818189636");
            //register.EnterUserName("vkrishna92");
            //register.EnterEmailID("vkrishna92@gmail.com");
            //register.EnterAboutYourSelf("abc");
            //register.EnterPassword("123");
            //register.ConfirmPassword("123");
            ((IJavaScriptExecutor)driver).ExecuteScript(
            "arguments[0].scrollIntoView();", register.firstName);
            register.profilePicUpload.Click();
            register.uploadFile(@"C:\Users\vkris\Desktop\SampleReport.txt");
            Thread.Sleep(5000);
        }
    }
}
