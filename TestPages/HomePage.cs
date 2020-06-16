using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace OtomationHw.TestPages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private By PopUpCloseBtn = By.ClassName("seg-popup-close");
        private By SearchDataTxb = By.Id("searchData");
        private By NavigationBtn = By.ClassName("next navigation");
        private By SelectPc = By.XPath("//*[@data-position='55']");
        private By AddBasKetBtn = By.XPath("//*[@class='btn btnGrey btnAddBasket']");
        private By ClickBasketBtn = By.XPath("//*[@class='myBasketHolder']");
        private By PriceProduct = By.XPath("//*[@class='newPrice']/ins");
        private By PriceInBasket = By.XPath("//*[@class='priceArea']/span");
        private By Quantity= By.ClassName("quantity");
        private By DeleteBasket = By.ClassName("removeProd svgIcon svgIcon_trash");
        private By ConfirmDelete = By.XPath("//*[@class='cartEmptyText']/h2");


        public void AddBasket()
        {
            GetElement(PopUpCloseBtn).Click();
            SendKeys(SearchDataTxb, "bilgisayar");

            GetElement(NavigationBtn).Click();

            string ConfirmSecondPage = driver.FindElement(By.XPath("//*[@class='pagination']/a")).Text;
            Console.WriteLine(ConfirmSecondPage);
            Assert.AreEqual(ConfirmSecondPage, 2);


            GetElement(SelectPc).Click();
            GetElement(AddBasKetBtn).Click();
            GetElement(ClickBasketBtn).Click();

            
           

            Assert.AreEqual(GetElement(PriceInBasket).Text, GetElement(PriceProduct).Text);

            //Adding Product
            List<IWebElement> element = driver.FindElements(By.ClassName("spinnerUp spinnerArrow")).ToList();
            element[0].Click();

            string Adet = "2";
            Assert.AreEqual(GetElement(Quantity).GetAttribute("value"), Adet);

            GetElement(DeleteBasket).Click();

            string ConfirmDeleteMsg = "Sepetiniz Boş";
            Console.WriteLine(ConfirmDeleteMsg);
            Assert.AreEqual(GetElement(ConfirmDelete).Text, ConfirmDeleteMsg);




        }


       

    }
}
