using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.pages
{
    class ShoppingCart
    {
        WebDriver driver;
        IWebElement CartIsEmpty;
        IWebElement RefreshItemButton;
        IWebElement DeleteItemButton;
        List<IWebElement> ProductNames;

        public ShoppingCart(WebDriver driver)
        {
            this.driver = driver;
            CartIsEmpty = driver.FindElement(By.CssSelector("//*[@id='content']/p"));
            RefreshItemButton = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[1]/td[4]/div/span/button[1]"));
            DeleteItemButton = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[1]/td[4]/div/span/button[2]"));
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
    }
}
