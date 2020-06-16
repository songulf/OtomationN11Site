using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace OtomationHw.TestPages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private By LoginBtn = By.ClassName("btnSignIn");
        private By MailAdress = By.XPath("//*[@id='email']");
        private By Password= By.XPath("//*[@id='password']");
        private By LoginSiteBtn = By.XPath("//*[@id='loginButton']");
        private By ConfirmLogin = By.XPath("//*[@title='Hesabım']");


        public HomePage LoginToSite()
        {
            string UserName = "UserName";
            string password = "password";

            GetElement(LoginBtn).Click();
            SendKeys(MailAdress, UserName);
            SendKeys(Password, password);
            GetElement(LoginSiteBtn).Click();

            Assert.IsTrue(GetElement(ConfirmLogin).Text.Equals("Hesabım"), "Kullanıcı girişi başarısız");

            if (GetElement(ConfirmLogin).Text == "Hesabım")
            {
                Console.WriteLine("Kullanıcı girişi sağlandı");
            }

            return new HomePage(driver);
        }




    }
}
