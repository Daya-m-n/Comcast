using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.ObjectRepository
{
    public class CreateNewOrganizationsPage
    {
        IWebDriver driver;
        public CreateNewOrganizationsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement orgNameEdt => driver.FindElement(By.Name("accountname"));
        private IWebElement saveButton => driver.FindElement(By.XPath("//textarea[@name='description']/following::input[@title='Save [Alt+S]']"));

        public IWebElement GetOrgNameEdt
        {
            get { return orgNameEdt; }
        }
        public IWebElement GetSaveButton
        {
            get { return saveButton; }
        }
        public void CreateOrganization(string orgName)
        {
            orgNameEdt.SendKeys(orgName);
            saveButton.Click();
        }
    }
}
