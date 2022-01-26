using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.ObjectRepository
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement userNameEdt => driver.FindElement(By.Name("user_name"));
        private IWebElement passwordEdt => driver.FindElement(By.Name("user_password"));
        private IWebElement loginButton => driver.FindElement(By.Id("submitButton"));

        public IWebElement GetUserNameEdt
        {
            get { return userNameEdt; }
        }
        public IWebElement GetPasswordEdt
        {
            get { return passwordEdt; }
        }
        public IWebElement GetLoginButton
        {
            get { return loginButton; }
        }

        public void Login(string url,string username, string password)
        {
            driver.Url=url;
            userNameEdt.SendKeys(username);
            passwordEdt.SendKeys(password);
            loginButton.Click();
        }
    }
}
