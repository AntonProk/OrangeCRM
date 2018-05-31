using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OrangeCRM.Pages;

namespace OrangeCRM.Tests
{
    class VerifyThatNewAttendanceRecordIsCreated : Elements.Elements
    {
        [SetUp]

        public void Initialized()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://opensource.demo.orangehrmlive.com");
        }
        [Test]
        public void VerifyThatNewAttendanceRecordIsDisplayed()
        {

            LoginPage loginpage = new LoginPage();
            PageFactory.InitElements(driver, loginpage);

            AdminView admin = new AdminView();
            PageFactory.InitElements(driver, admin);

            TimeView timetab = new TimeView();
            PageFactory.InitElements(driver, timetab);

            loginpage.LoginAsAdmin();

            timetab.TimeTabClick();
            timetab.AttendanceTabClick();
            timetab.EmployeeRecordSelect();
            timetab.FillUpTheForm(EmployeeName);


            Assert.That(timetab.SelectValueFromTable(1), Is.EqualTo(Resource.PunchInValue));

            timetab.AddAttendanceRecordClick();
            timetab.PunchInForm();
            Assert.That(timetab.SelectValueFromTable(3), Is.EqualTo(Resource.PunchInNote));

            timetab.DeleteEmployeeAttendance();
        }

        [TearDown]

        public void CleanUp()
        {
            driver.Close();
        }
    }
}
