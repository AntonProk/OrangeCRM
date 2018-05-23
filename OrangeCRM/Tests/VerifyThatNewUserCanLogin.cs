using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OrangeCRM.Elements;
using OrangeCRM.Pages;

namespace OrangeCRM.Tests
{
    public class VerifyThatNewUserCanLogin
    {
        [SetUp]

        public void Initialized()
        {
            DriverInit.driver = new ChromeDriver();
            DriverInit.driver.Navigate().GoToUrl("http://opensource.demo.orangehrmlive.com");
        }
        [Test]
        public void SignIn()
        {

            LoginPage loginpage = new LoginPage();
            PageFactory.InitElements(DriverInit.driver, loginpage);
            AdminView admin = new AdminView();
            PageFactory.InitElements(DriverInit.driver, admin);

            loginpage.LoginAsAdmin();


            admin.OpenAdminView();
            admin.AddBtnClick();
            admin.AddUser();

            admin.OpenWelcomeDropDown();
            admin.LogoutClick();

            DashboardPage dashboard = new DashboardPage();
            PageFactory.InitElements(DriverInit.driver, dashboard);

            loginpage.LoginAsNewUser();
            Assert.That(dashboard.IsPageDisplayed, Is.True);
        }      

        [TearDown]

        public void CleanUp()
        {
            DriverInit.driver.Close();  
        }
    }
}
