using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OrangeCRM.Pages
{
   public class LoginPage : Elements.Elements
    {

        [FindsBy(How = How.Id, Using = "txtUsername")]
        private IWebElement userName;

        [FindsBy(How = How.Id, Using = "txtPassword")]
        private IWebElement userPwd;

        [FindsBy(How = How.Id, Using = "btnLogin")]
        private IWebElement loginBtn;


        public void LoginAsAdmin()
        {
            userName.SendKeys(AdminName);
            userPwd.SendKeys(AdminPwd);
            loginBtn.Click();
        }

        public void LoginAsNewUser(string NewUser)
        {
            userName.SendKeys(NewUser);
            userPwd.SendKeys(UserPwd);
            loginBtn.Click();
        }
    }
}
