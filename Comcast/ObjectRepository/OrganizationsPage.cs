using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.ObjectRepository
{
    public class OrganizationsPage
    {
        IWebDriver driver;
        public OrganizationsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement createOrgImg => driver.FindElement(By.XPath("//img[@title='Create Organization...']"));

        public IWebElement GetCreateOrgImg
        {
            get { return createOrgImg; }
        }
    }
}
