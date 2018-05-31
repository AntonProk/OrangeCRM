using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace OrangeCRM.Pages
{
    class PIMView : Elements.Elements
    {
        [FindsBy(How = How.Id, Using = "menu_pim_viewPimModule")]
        private IWebElement pimTab;

        [FindsBy(How = How.Id, Using = "btnAdd")]
        private IWebElement addBtn;

        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement firstNameField;

        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement lastNameField;

        [FindsBy(How = How.Id, Using = "btnSave")]
        private IWebElement saveBtn;

        [FindsBy(How = How.CssSelector, Using = "#welcome-menu > ul > li:nth-child(2) > a")]
        private IWebElement logoutBtn;

        [FindsBy(How = How.Id, Using = "welcome")]
        public IWebElement welcomeDropDownLink;

        [FindsBy(How = How.Id, Using = "resultTable")]
        private IList<IWebElement> resultTable;


        public bool IsPageDisplayed => firstNameField.Displayed;

        public void OpenPIMView()
        {
            pimTab.Click();
        }

        public void AddBtnClick()
        {
            addBtn.Click();
        }

        public string FirstNameUuid => firstNameField.GetAttribute("value");


        public void FillUpThePIMForm()
        {
            firstNameField.SendKeys(UserFirstName);
            lastNameField.SendKeys(UserLastName);
        }

        public void SubmitThePIMForm()
        {
            saveBtn.Click();
            System.Threading.Thread.Sleep(5);
        }
    }
}