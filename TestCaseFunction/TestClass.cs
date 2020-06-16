using Microsoft.VisualStudio.TestTools.UnitTesting;
using OtomationHw.TestPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomationHw.TestCaseFunction
{
    [TestClass]
    public class TestClass:BaseTest
    {


        [TestMethod]
        public void Test()
        {
            LoginPage login = new LoginPage(driver);

            login.LoginToSite();
            HomePage homepage = login.LoginToSite();
            homepage.AddBasket();
        }



    }
}
