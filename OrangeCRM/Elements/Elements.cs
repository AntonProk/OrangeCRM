using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OrangeCRM.Elements
{
    public class Elements
    {
        public static IWebDriver driver { get; set; }

        public static Guid generatedUserName = Guid.NewGuid();
        public static Guid generateFirstName = Guid.NewGuid();


        protected string UserName = "AntonProk" + generatedUserName;
        protected string UserFirstName = "FirstName" + generateFirstName;
        protected string UserLastName = "LastName" + generatedUserName;
        protected string EmployeeName = "FirstName";

        protected string UserPwd = "Pssword1";


        protected string AdminName = "Admin";
        protected string AdminPwd = "admin";
    }
}
