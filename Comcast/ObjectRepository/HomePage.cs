using Comcast.GenericUtility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.ObjectRepository
{
    public class HomePage:WebDriverUtility
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement organizationsLink => driver.FindElement(By.LinkText("Organizations"));
        private IWebElement adminstratorImg => driver.FindElement(By.XPath("//img[@src='themes/softed/images/user.PNG']"));
        private IWebElement logOutLink => driver.FindElement(By.XPath("//a[text()='Sign Out']"));
        public IWebElement GetOrganizationsLink
        {
            get { return organizationsLink; }
        }
        public IWebElement GetAdminstratorImg
        {
            get { return adminstratorImg; }
        }
        public IWebElement GetLogOutLink
        {
            get { return logOutLink; }
        }

        public void LogOut()
        {
            MouseHoverOnElement(driver,adminstratorImg);
            logOutLink.Click();
        }
    }
}
