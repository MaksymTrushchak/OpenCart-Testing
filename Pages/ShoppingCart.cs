using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.Pages
{ 
    class ShoppingCart
    {
        public WebDriver driver;

        private IWebElement RefreshProductButton;
        private IWebElement DeleteProduct1Button;
        private IWebElement DeleteProduct2Button;
        private IWebElement DeleteProduct3Button;

        private IWebElement Continue;
        private IWebElement Subtotal { get; }
        private IWebElement Total { get; }

        private IWebElement CheckoutButton;

        public ShoppingCart(WebDriver driver)
        {
            this.driver = driver;

            try
            {
                RefreshProductButton = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr/td[4]/div/span/button[1]"));
            } catch (OpenQA.Selenium.NoSuchElementException) { }

            try
            {
                DeleteProduct1Button = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr/td[4]/div/span/button[2]"));
            }
            catch (OpenQA.Selenium.NoSuchElementException) { }
            
            try
            { 
                DeleteProduct2Button = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[2]/td[4]/div/span/button[2]"));
                DeleteProduct3Button = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[3]/td[4]/div/span/button[2]"));
            }
            catch (OpenQA.Selenium.NoSuchElementException) { }

            Subtotal = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div/table/tbody/tr[1]/td[2]"));
            Total = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div/table/tbody/tr[4]/td[2]"));
            CheckoutButton = driver.FindElement(By.LinkText("Checkout"));
        }

        public void RefreshProduct()
        {
            RefreshProductButton.Click();
        }
        public void RemoveProduct1()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr/td[4]/div/span/button[2]")).Click();
        }
        public void RemoveProduct2()
        {
            DeleteProduct2Button.Click();
        }
        public void RemoveProduct3()
        {
            DeleteProduct3Button.Click();
        }
        public void ClickContinue()
        {
            Continue = driver.FindElement(By.XPath("//*[@id='content']/div/div/a"));
        }
    }
}
