using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomationHw
{
    [TestClass]
    [TestCategory("BaseTest")]
    public class BaseTest
    {
        public static IWebDriver driver;
        string URL = "https://www.n11.com/";


        [TestInitialize]
        public void OpenBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();

            string ConfirmToSiteMsg = driver.FindElement(By.XPath("//*[@class='btnSignIn']")).Text;
            Console.WriteLine(ConfirmToSiteMsg);

            Assert.AreEqual(ConfirmToSiteMsg, "Giriş Yap");

        }

        [TestCleanup]

        public void CleanUpDriver()
        {
            driver.Close();
            driver.Quit();

        }



    }
}
