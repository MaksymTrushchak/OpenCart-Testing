using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System;

namespace OpencartTesting.Pages
{
    class ProductsPage : MainPageHeader
    {
        public WebDriver driver;
        public IWebElement Product1ToCart
        {
            get
            {
                return driver.FindElement(By.XPath("//div[1]/div/div[2]/div[2]/button[1]"));
            }
        }
        public IWebElement Product2ToCart
        {
            get
            {
                return driver.FindElement(By.XPath("//div[2]/div/div[2]/div[2]/button[1]"));
            }
        }
        public IWebElement Product3ToCart
        {
            get
            {
                return driver.FindElement(By.XPath("//div[3]/div/div[2]/div[2]/button[1]"));
            }
        }

        public ProductsPage(WebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public void AddProduct1ToCart()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Product1ToCart.Click();
        }
        public void AddProduct2ToCart()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Product2ToCart.Click();
        }
        public void AddProduct3ToCart()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Product3ToCart.Click();
        }
        public void NavigateToPhonesAndPDAs()
        {
            driver.FindElement(By.LinkText("Phones & PDAs")).Click();
        }
    }
}