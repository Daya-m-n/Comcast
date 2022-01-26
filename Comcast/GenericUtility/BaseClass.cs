using Comcast.ObjectRepository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.GenericUtility
{
    public class BaseClass
    {
        public IWebDriver driver;
        public TestContext TestContext { get; set; }

        [OneTimeSetUp]
        public void LaunchBrowser()
        {
            string browser = TestContext.Parameters.Get("browser");
            if (browser.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (browser.Equals("firefox"))
            {
                driver= new ChromeDriver();
            }
            else
            {
                driver=new ChromeDriver();
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(15);
        }

        [SetUp]
        public void LoginToApplication()
        {
            string url = TestContext.Parameters.Get("url");
            string username =TestContext.Parameters.Get("username");
            string password= TestContext.Parameters.Get("password");
            LoginPage lp=new LoginPage(driver);
            lp.Login(url,username,password);
        }

        [TearDown]
        public void LogoutFromTheApplication() 
        {
            HomePage hp=new HomePage(driver);
            hp.LogOut();
        }

        [OneTimeTearDown]
        public void CloseBrowser() 
        {
           // driver.Close();
        }
    }
}
