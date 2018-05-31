using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace OrangeCRM.Pages
{
    public class TimeView : Elements.Elements
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"ui-datepicker-div\"]/table/tbody/tr[5]/td[3]/a")]
        private IWebElement dateSelector;

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]")]
        private IList<IWebElement> autoSuggetions;

        [FindsBy(How = How.Id, Using = "menu_dashboard_index")]
        private IWebElement dashboardTab;

        [FindsBy(How = How.CssSelector, Using = "#menu_attendance_viewAttendanceRecord")]
        private IWebElement employeeRecord;

        [FindsBy(How = How.Id, Using = "menu_attendance_Attendance")]
        private IWebElement attendanceTab;

        [FindsBy(How = How.Id, Using = "attendance_date")]
        private IWebElement attendanceDate;

        [FindsBy(How = How.Id, Using = "attendance_time")]
        private IWebElement punchInTimefield;

//        [FindsBy(How = How.Id, Using = "attendance_timezone")]
//        private IList<IWebElement> punchInTimeZoneDropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"attendance_timezone\"]")]
        private IWebElement punchInTimeZoneDropDownClick;

        [FindsBy(How = How.Id, Using = "attendance_note")]
        private IWebElement punchInNoteField;

        [FindsBy(How = How.Id, Using = "btnPunch")]
        private IWebElement punchInBtn;

        [FindsBy(How = How.Id, Using = "ohrmList_chkSelectAll")]
        private IWebElement employeeCheckBox;

        [FindsBy(How = How.Id, Using = "btnDelete")]
        private IWebElement deleteBtn;

        [FindsBy(How = How.Id, Using = "menu_time_viewTimeModule")]
        private IWebElement timeHeaderMenu;

        [FindsBy(How = How.Id, Using = "attendance_employeeName_empName")]
        private IWebElement employeeName;

        [FindsBy(How = How.Id, Using = "btView")]
        private IWebElement viewBtn;

        [FindsBy(How = How.Id, Using = "btnPunchOut")]
        private IWebElement attendanceBtn;

        [FindsBy(How = How.Id, Using = "dialogBox")]
        private IWebElement deleteConfirmationBox;

        [FindsBy(How = How.Id, Using = "okBtn")]
        private IWebElement okBtn;

        //       [FindsBy(How = How.Id, Using = "resultTable")]
        //        private IList<IWebElement> resultTable;

        [FindsBy(How = How.XPath, Using = "//tr[@class='odd']//td")]
        private IList<IWebElement> resultTable;

        //       [FindsBy(How = How.XPath, Using = "//*[@id=\"resultTable\"]/tbody/tr/td[2]")]
        //        private IWebElement resultTable;

        public bool IsPageDisplayed => dashboardTab.Displayed;

        public void TimeTabClick()

        {
            timeHeaderMenu.Click();
        }

        public void AttendanceTabClick()

        {
            attendanceTab.Click();
        }

        public void EmployeeRecordSelect()

        {
            employeeRecord.Click();
        }

        public void FillUpTheForm(string EmployeeName)
        {
            employeeName.SendKeys(EmployeeName);
            autoSuggetions.First().Click();
            attendanceDate.Click();
            dateSelector.Click();
            viewBtn.Click();
        }

        public string SelectValueFromTable(int index)
        {
           string result = resultTable[index].Text;
           return result;
        }


        public void AddAttendanceRecordClick()
        {
            attendanceBtn.Click();
        }

        public void PunchInForm()
        {
            punchInTimefield.Clear();
            punchInTimefield.SendKeys("18:00");
            punchInTimeZoneDropDownClick.Click();
            var selectElement = new SelectElement(punchInTimeZoneDropDownClick);
            selectElement.SelectByValue("5");

            punchInNoteField.SendKeys("Some random text");
            punchInBtn.Click();
        }

        public void DeleteEmployeeAttendance()
        {
            employeeCheckBox.Click();
            deleteBtn.Click();
            IList<string> windowList = driver.WindowHandles.ToList();
            foreach (var newmodalwindow in windowList)
            {
                driver.SwitchTo().Window(newmodalwindow);              
            }
           
            okBtn.Click();
        }
    }
}
