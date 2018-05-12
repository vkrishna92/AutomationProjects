using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumAutomationDemoQA.Utitlities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumAutomationDemoQA.POM.PageObjects
{
    class RegistrationPage
    {
        private IWebDriver driver;

        public RegistrationPage(IWebDriver dr)
        {
            driver = dr;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "name_3_firstname")]
        public IWebElement firstName;

        [FindsBy(How = How.Id, Using = "name_3_lastname")]
        public IWebElement lastName;

        [FindsBy(How = How.Name, Using = "radio_4[]")]
        public IWebElement maritalStatus;

        [FindsBy(How = How.Id, Using = "checkbox_5[]")]
        public IWebElement hobby;

        [FindsBy(How = How.Id, Using = "dropdown_7")]
        public IWebElement country;

        [FindsBy(How = How.Id, Using = "mm_date_8")]
        public IWebElement dateofMonth;
        [FindsBy(How = How.Id, Using = "dd_date_8")]
        public IWebElement dateofDay;
        [FindsBy(How = How.Id, Using = "yy_date_8")]
        public IWebElement dateofYear;

        [FindsBy(How = How.Id, Using = "phone_9")]
        public IWebElement phoneNumber;

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement userName;

        [FindsBy(How = How.Id, Using = "email_1")]
        public IWebElement emailID;

        [FindsBy(How = How.Id, Using = "profile_pic_10")]
        public IWebElement profilePicUpload;

        [FindsBy(How = How.Id, Using = "description")]
        public IWebElement aboutSelf;

        [FindsBy(How = How.Id, Using = "password_2")]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "confirm_password_password_2")]
        public IWebElement confirmPassword;

        [FindsBy(How = How.Id, Using = "piereg_passwordStrength")]
        public IWebElement passwordStrength;

        [FindsBy(How = How.Name, Using = "pie_submit")]
        public IWebElement submitBtn;
    
        public void EnterFullName(string first_name, string last_name)
        {
            firstName.Clear();
            firstName.SendKeys(first_name);
            lastName.Clear();
            lastName.SendKeys(last_name);
        }
        public void marital_Status(string marital_status)
        {
            var statuses = maritalStatus.FindElements(By.TagName("input"));
            var req_status = from c in statuses
                             where c.GetAttribute("value") == marital_status.ToLower()
                              select c;
            req_status.FirstOrDefault().Click();
        }

        public void check_hobby(string hobbies)
        {
            var avail_hobbies = hobby.FindElements(By.TagName("input"));
            var req_hobby = from h in avail_hobbies
                            where h.GetAttribute("value") == hobbies.ToLower()
                            select h;
            req_hobby.FirstOrDefault().Click();
        }
        public void Select_country(string country_name)
        {
            SelectElement country_names = new SelectElement(country);
            country_names.SelectByText(country_name);
        }
        private void selectMonth(string mm)
        {
            SelectElement month = new SelectElement(dateofMonth);
            month.SelectByText(mm);
        }
        private void selectDay(string dd)
        {
            SelectElement month = new SelectElement(dateofDay);
            month.SelectByText(dd);
        }
        private void selectYear(string yyyy)
        {
            SelectElement month = new SelectElement(dateofYear);
            month.SelectByText(yyyy);
        }
        public void selectDateofBirth(string mm,string dd,string yyyy)
        {
            selectMonth(mm);
            selectDay(dd);
            selectYear(yyyy);
        }
        public void EnterPhoneNumber(string phone_number)
        {
            phoneNumber.Clear();
            phoneNumber.SendKeys(phone_number);
        }
        public void EnterUserName(string user_name)
        {
            userName.Clear();
            userName.SendKeys(user_name);
        }
        public void EnterEmailID(string email_id)
        {
            emailID.Clear();
            emailID.SendKeys(email_id);
        }
        public void EnterAboutYourSelf(string about_self)
        {
            aboutSelf.Clear();
            aboutSelf.SendKeys(about_self);
        }
        public void EnterPassword(string pwd)
        {
            password.Clear();
            password.SendKeys(pwd);
        }
        public void ConfirmPassword(string pwd)
        {
            confirmPassword.Clear();
            confirmPassword.SendKeys(pwd);
        }
        public void uploadFile(string filePath)
        {
            FileUpload.UploadFile(profilePicUpload, filePath);
        }
    }
}
