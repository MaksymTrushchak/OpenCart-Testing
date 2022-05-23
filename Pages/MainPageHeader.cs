using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.Pages
{
    abstract class MainPageHeader
    {
        protected WebDriver driver;

        public IWebElement shoppingCart
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[4]"));
            }
        }
        public IWebElement checkout
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[5]"));
            }
        }

        public IWebElement cartButton
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='cart']/button"));
            }
        }
        private IWebElement total
        {
            get
            {
                return driver.FindElement(By.CssSelector("#cart-total"));
            }
        }

        public MainPageHeader(WebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickShoppingCart() { shoppingCart.Click(); }
        public void ClickCheckout() { checkout.Click(); }
        public void ViewCart() { cartButton.Click(); }
    }
}
