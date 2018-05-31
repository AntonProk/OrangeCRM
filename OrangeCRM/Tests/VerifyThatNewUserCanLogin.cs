using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    public class VerifyThatNewUserCanLogin : Elements.Elements
    {
        [SetUp]

        public void Initialized()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://opensource.demo.orangehrmlive.com");
        }
        [Test]
        public void VerifyThatNewUserIsCreatedAndCanLogIn()
        {

            LoginPage loginpage = new LoginPage();
            PageFactory.InitElements(driver, loginpage);

            PIMView pimview = new PIMView();
            PageFactory.InitElements(driver, pimview);

            AdminView admin = new AdminView();
            PageFactory.InitElements(driver, admin);

            loginpage.LoginAsAdmin();

            pimview.OpenPIMView();
            pimview.AddBtnClick();
            pimview.FillUpThePIMForm();
            var firstUserName = pimview.FirstNameUuid;
            pimview.SubmitThePIMForm();

            admin.OpenAdminView();
            admin.AddBtnClick();
            admin.FillUpTheForm(firstUserName);
            var u = admin.NewUserUuid;
            admin.SubmitTheForm();
            Thread.Sleep(1000);


            admin.OpenWelcomeDropDown();
            admin.LogoutClick();

            TimeView dashboard = new TimeView();
            PageFactory.InitElements(driver, dashboard);
            loginpage.LoginAsNewUser(u);
            Assert.That(dashboard.IsPageDisplayed, Is.True);
        }      

        [TearDown]

        public void CleanUp()
        {
            driver.Close();  
        }
    }
}
