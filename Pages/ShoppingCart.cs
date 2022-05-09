using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.Pages
{ 
    class ShoppingCart
    {
        public WebDriver driver;

        private IWebElement DeleteProduct1;
        private IWebElement DeleteProduct2;
        private IWebElement DeleteProduct3;

        private IWebElement Subtotal { get; }
        private IWebElement Total { get; }

        private IWebElement CheckoutButton;

        public ShoppingCart(WebDriver driver)
        {
            this.driver = driver;
           
            DeleteProduct1 = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[3]/td[4]/div/span/button[2]"));
            DeleteProduct2 = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[2]/td[4]/div/span/button[2]"));
            DeleteProduct3 = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[1]/td[4]/div/span/button[2]"));

            Subtotal = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div/table/tbody/tr[1]/td[2]"));
            Total = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div/table/tbody/tr[4]/td[2]"));
            CheckoutButton = driver.FindElement(By.LinkText("Checkout"));
        }

        public void RemoveProduct1()
        {
            DeleteProduct1.Click();
        }
        public void RemoveProduct2()
        {
            DeleteProduct1.Click();
        }
        public void RemoveProduct3()
        {
            DeleteProduct1.Click();
        }
    }
}
