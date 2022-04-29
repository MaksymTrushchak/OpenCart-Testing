using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.pages
{
    class MainPage
    {
        WebDriver driver;
        IWebElement shoppingCart;
        IWebElement cart;
        IWebElement total;
        IWebElement checkout;

        public MainPage(WebDriver driver)
        {
            this.driver = driver;
            shoppingCart = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[4]"));
            cart = driver.FindElement(By.XPath("//*[@id='cart']/button"));
            total = driver.FindElement(By.CssSelector("#cart-total"));
            checkout = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[5]"));
        }

        public void ClickCheckout()
        {
            checkout.Click();
        }
    }
}
