using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace OrangeCRM.Pages
{
   public class AdminView : Elements.Elements
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

        [FindsBy(How = How.ClassName, Using = "ac_results")]
        private IWebElement autoSuggestion;

        [FindsBy(How = How.Id, Using = "btnSave")]
        private IWebElement saveBtn;

        [FindsBy(How = How.CssSelector, Using = "#welcome-menu > ul > li:nth-child(2) > a")]
        private IWebElement logoutBtn;

        [FindsBy(How = How.Id, Using = "welcome")]
        public IWebElement welcomeDropDownLink;

        [FindsBy(How = How.Id, Using = "resultTable")]
        private IList<IWebElement> resultTable;


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
            welcomeDropDownLink.Click();
            Thread.Sleep(1000);
        }
        public void LogoutClick()
        {
            logoutBtn.Click();
        }

        public string NewUserUuid => userNameField.GetAttribute("value");


        public void FillUpTheForm(string EmployeeName)
        {
            employeeNameField.SendKeys(EmployeeName);
            Thread.Sleep(500);
            autoSuggestion.Click();

            userNameField.SendKeys(UserName);
            userPwd.SendKeys(UserPwd);
            confirmPwd.SendKeys(UserPwd);
        }

        public void SubmitTheForm()
        {
            saveBtn.Click();
        }
    }
}
