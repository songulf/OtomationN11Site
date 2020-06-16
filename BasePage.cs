using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomationHw
{
   public class BasePage
    {

        public IWebDriver driver;
        
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            

        }
        public IWebElement GetElement(By locator)
        {

            return driver.FindElement(locator);

        }
        public void SendKeys(By locator, string value)
        {
            GetElement(locator).SendKeys(value);
        }
    }
}
