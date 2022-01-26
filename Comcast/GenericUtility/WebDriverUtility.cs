using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comcast.GenericUtility
{
    public class WebDriverUtility
    {
        public void MouseHoverOnElement(IWebDriver driver,IWebElement ele)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(ele).Perform();
        }
    }
}
