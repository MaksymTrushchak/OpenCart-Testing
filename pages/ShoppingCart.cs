using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.pages
{
    class ShoppingCart
    {
        WebDriver driver;
        IWebElement refresh;

        public ShoppingCart(WebDriver driver)
        {
            this.driver = driver;
            refresh = driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[1]/td[4]/div/span/button[1]"));
        }

        public void RefreshItem()
        {
            refresh.Click();
        }
    }
}
