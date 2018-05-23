using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OrangeCRM.Pages
{
   public class LoginPage
    {

        [FindsBy(How = How.Id, Using = "txtUsername")]
        private IWebElement userName;

        [FindsBy(How = How.Id, Using = "txtPassword")]
        private IWebElement userPwd;

        [FindsBy(How = How.Id, Using = "btnLogin")]
        private IWebElement loginBtn;


        private string AdminName = "Admin";
        private string AdminPwd = "admin";

        private string Username = "AntonProk";
        private string UserPwd = "Password1";

        public void LoginAsAdmin()
        {
            userName.SendKeys(AdminName);
            userPwd.SendKeys(AdminPwd);
            loginBtn.Click();
        }

        public void LoginAsNewUser()
        {
            userName.SendKeys(Username);
            userPwd.SendKeys(UserPwd);
            loginBtn.Click();
        }
    }
}
