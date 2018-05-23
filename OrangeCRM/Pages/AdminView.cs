using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace OrangeCRM.Pages
{
   public class AdminView
    {
        [FindsBy(How = How.Id, Using = "menu_admin_viewAdminModule")]
        private IWebElement adminTab;

        [FindsBy(How = How.Id, Using = "btnAdd")]
        private IWebElement addBtn;

        [FindsBy(How = How.Id, Using = "systemUser_employeeName_empName")]
        private IWebElement employeeNameField;

        [FindsBy(How = How.Id, Using = "systemUser_userName")]
        private IWebElement userNameField;

        [FindsBy(How = How.Id, Using = "systemUser_password")]
        private IWebElement userPwd;

        [FindsBy(How = How.Id, Using = "systemUser_confirmPassword")]
        private IWebElement confirmPwd;

        [FindsBy(How = How.Id, Using = "btnSave")]
        private IWebElement saveBtn;

        [FindsBy(How = How.CssSelector, Using = "#welcome-menu > ul > li:nth-child(2) > a")]
        private IWebElement logoutBtn;

        [FindsBy(How = How.Id, Using = "welcome")]
        private IWebElement welcomDropDownLink;

        [FindsBy(How = How.Id, Using = "resultTable")]
        private IList<IWebElement> resultTable;

        



        private string EmployeeName = "toto2 toto2";
        private string UserName = "AntonProk";
        private string UserPwd = "Pssword1";

        public bool IsPageDisplayed => userNameField.Displayed;

        public void OpenAdminView()
        {
            adminTab.Click();
        }

        public void AddBtnClick()
        {
            addBtn.Click();
        }

        public void OpenWelcomeDropDown()
        {
            welcomDropDownLink.Click();
        }
        public void LogoutClick()
        {
            logoutBtn.Click();
        }

        public void AddUser()
        {
            employeeNameField.SendKeys(EmployeeName);
            userNameField.SendKeys(UserName);
            userPwd.SendKeys(UserPwd);
            confirmPwd.SendKeys(UserPwd);
            saveBtn.Click();

            //Sorry, for this implicit wait. Temporary solution
            System.Threading.Thread.Sleep(1000);
        }

        //Need to create some user generator method or use delete user method every time

        public void DeleteUser()
        {
            //Need to implement this method
        }
    }
}
