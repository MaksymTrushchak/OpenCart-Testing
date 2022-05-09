using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace OpencartTesting.Pages
{
    class ProductsPage
    {
        public WebDriver driver;
        private IWebElement Product1ToCart;
        private IWebElement Product2ToCart;
        private IWebElement Product3ToCart;

        public ProductsPage(WebDriver driver)
        {
            this.driver = driver;

            Product1ToCart = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[2]/div[2]/button[1]"));
            Product2ToCart = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[2]/div/div[2]/div[2]/button[1]"));
            Product3ToCart = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[3]/div/div[2]/div[2]/button[1]"));

        }
        public void AddProduct1ToCart()
        {
            Product1ToCart.Click();
        }
        public void AddProduct2ToCart()
        {
            Product2ToCart.Click();
        }
        public void AddProduct3ToCart()
        {
            Product3ToCart.Click();
        }
        public void NavigateToPhonesAndPDAs()
        {
            driver.FindElement(By.LinkText("Phones & PDAs")).Click();
        }
    }
}
