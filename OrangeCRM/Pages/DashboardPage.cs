using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace OrangeCRM.Pages
{
    class DashboardPage
    {
        [FindsBy(How = How.ClassName, Using = ".ui-datepicker-calendar > tbody")]
        private IList<IWebElement> datepicker;

        [FindsBy(How = How.ClassName, Using = ".menu")]
        private IList<IWebElement> headerMenu;

        [FindsBy(How = How.Id, Using = "menu_dashboard_index")]
        private IWebElement dashboardTab;

        [FindsBy(How = How.CssSelector, Using = "#menu_attendance_viewAttendanceRecord")]
        private IWebElement employeeRecord;

        [FindsBy(How = How.Id, Using = "menu_attendance_Attendance")]
        private IWebElement attendanceTab;

        [FindsBy(How = How.Id, Using = "attendance_date")]
        private IWebElement attendanceDate;

        [FindsBy(How = How.Id, Using = "menu_time_viewTimeModule")]
        private IWebElement timeHeaderMenu;

        public bool IsPageDisplayed => dashboardTab.Displayed;

        public void TimeTabClick()

        {
            timeHeaderMenu.Click();
        }

        public void AttendanceTabClick()

        {
            timeHeaderMenu.Click();
        }
        public void EmployeeRecordSelect()

        {
            employeeRecord.Click();
        }

        public void OpenCalendar()
        {
            attendanceDate.Click();
        }

        public string RetriveDataFromList(int index)

        {
            return datepicker[index].Text;
        }
    }
}
