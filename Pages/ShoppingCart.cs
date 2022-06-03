using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace OpencartTesting.Pages
{
    class ShoppingCart : MainPageHeader
    {
        public WebDriver driver;

        public IWebElement RefreshProductButton
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr/td[4]/div/span/button[1]"));
            }
        }
        public IWebElement DeleteProduct1Button
        {
            get
            {
                return driver.FindElement(By.XPath("//table/tbody/tr/td[4]/div/span/button[2]"));
            }
        }
        public IWebElement DeleteProduct2Button
        {
            get
            {
                return driver.FindElement(By.XPath("//table/tbody/tr[2]/td[4]/div/span/button[2]"));
            }
        }
        public IWebElement DeleteProduct3Button
        {
            get
            {
                return driver.FindElement(By.XPath("//table/tbody/tr[3]/td[4]/div/span/button[2]"));
            }
        }
        public IWebElement Continue
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='content']/div/div/a"));
            }
        }
        public IWebElement CheckoutButton
        {
            get
            {
                return driver.FindElement(By.LinkText("Checkout"));
            }
        }

        public ShoppingCart(WebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void RefreshProduct()
        {
            RefreshProductButton.Click();
        }
        public void RemoveProduct1()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            DeleteProduct1Button.Click();
        }
        public void RemoveProduct2()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            DeleteProduct2Button.Click();
        }
        public void RemoveProduct3()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            DeleteProduct3Button.Click();
        }
        public void ClickContinue()
        {
            Continue.Click();
        }
        public string getCartUpdatedMessage()
        {
            try
            {
                return driver.FindElement(By.XPath("//*[@id='checkout - cart']/div[1]")).Text;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
    }
}