using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.pages
{
    class MainPageHeader
    {
        protected WebDriver driver;
        private IWebElement currency;
        private IWebElement myAccount;
        private IWebElement wishlist;
        private IWebElement shoppingCart;
        private IWebElement checkout;
        private IWebElement logo;
        private IWebElement searchField;
        private IWebElement searchButton;
        private IWebElement topMenu;
        private IWebElement cartButton;
        private IWebElement total;

        public MainPageHeader(WebDriver driver)
        {
            this.driver = driver;

            currency = driver.FindElement(By.XPath("//*[@id='form - currency']/div/button"));
            myAccount = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[2]"));
            wishlist = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[3]"));
            shoppingCart = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[4]"));
            checkout = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[5]"));

            logo = driver.FindElement(By.CssSelector("#logo > a"));
            searchField = driver.FindElement(By.Name("search"));
            searchButton = driver.FindElement(By.CssSelector(".btn.btn-default.btn-lg"));
            cartButton = driver.FindElement(By.XPath("//*[@id='cart']/button"));
            total = driver.FindElement(By.CssSelector("#cart-total"));

            topMenu = driver.FindElement(By.CssSelector("//*[@id='menu']/div[2]/ul"));
        }

        public IWebElement getTotal() { return total; }

        public void ClickCheckout()
        {
            checkout.Click();
        }
    }
}
