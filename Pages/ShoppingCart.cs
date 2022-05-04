using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.Pages
{ 
    class ShoppingCart : MainPageHeader
    {
        public WebDriver driver;

        private IWebElement CartIsEmpty;

        List<IWebElement> ProductNames;
        private IWebElement RefreshItemButton;
        private IWebElement DeleteItemButton;

        private IWebElement CouponCodeExpandCollapse;
        private IWebElement GiftCertExpandCollapse;

        private IWebElement Subtotal { get; }
        private IWebElement Total { get; }

        private IWebElement ContinueShippingButton;
        private IWebElement CheckoutButton;

        public ShoppingCart(WebDriver driver) : base(driver)
        {
            this.driver = driver;
            CartIsEmpty = driver.FindElement(By.CssSelector("//*[@id='content']/p"));
            RefreshItemButton = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[1]/td[4]/div/span/button[1]"));
            DeleteItemButton = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[1]/td[4]/div/span/button[2]"));

            CouponCodeExpandCollapse = driver.FindElement(By.XPath("//*[@id='accordion']/div[1]/div[1]/h4/a"));
            GiftCertExpandCollapse = driver.FindElement(By.XPath("//*[@id='accordion']/div[3]/div[1]/h4/a"));

            Subtotal = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div/table/tbody/tr[1]/td[2]"));
            Total = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div/table/tbody/tr[4]/td[2]"));

            ContinueShippingButton = driver.FindElement(By.LinkText("Continue Shopping"));
            CheckoutButton = driver.FindElement(By.LinkText("Checkout"));
        }

        public void RefreshItems(int items)
        {
            for (int i = 0; i < items; i++)
            {
                RefreshItemButton.Click();
                RefreshItemButton = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[1]/td[4]/div/span/button[1]" +
                    "/following-sibling::button"));

                if (RefreshItemButton == null) break;
            }
        }
        public void DeleteItems(int items)
        {
            for (int i = 0; i < items; i++)
            {
                DeleteItemButton.Click();
                DeleteItemButton = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[1]/td[4]/div/span/button[2]" +
                    "/following-sibling::button"));

                if (DeleteItemButton == null) break;
            }
        }
        public void ExColCouponCode()
        {
            CouponCodeExpandCollapse.Click();
        }
        public void ExColGiftCert()
        {
            GiftCertExpandCollapse.Click();
        }
    }
}
