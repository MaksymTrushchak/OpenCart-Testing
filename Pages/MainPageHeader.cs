using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.Pages
{
    abstract class MainPageHeader
    {
        protected WebDriver driver;

        private IWebElement currency;
        private IWebElement myAccount;
        private IWebElement wishlist;
        private IWebElement shoppingCart;
        private IWebElement checkout;

        private IWebElement logo;
        private IWebElement searchBar;
        private IWebElement searchButton;
        private IWebElement cartButton;
        private IWebElement total;

        private IWebElement topMenu;

        public MainPageHeader(WebDriver driver)
        {
            this.driver = driver;

            currency = driver.FindElement(By.XPath("//*[@id='form - currency']/div/button"));
            myAccount = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[2]"));
            wishlist = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[3]"));
            shoppingCart = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[4]"));
            checkout = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[5]"));

            logo = driver.FindElement(By.CssSelector("#logo > a"));
            searchBar = driver.FindElement(By.Name("search"));
            searchButton = driver.FindElement(By.CssSelector(".btn.btn-default.btn-lg"));
            cartButton = driver.FindElement(By.XPath("//*[@id='cart']/button"));
            total = driver.FindElement(By.CssSelector("#cart-total"));

            topMenu = driver.FindElement(By.CssSelector("//*[@id='menu']/div[2]/ul"));
        }

        public IWebElement GetCurrency() => driver.FindElement(By.XPath("//*[@id='form-currency']/div/button/strong"));
        public void ClickShoppingCart() { shoppingCart.Click(); }
        public void ClickCheckout() { checkout.Click(); }
        public void ViewCart() { cartButton.Click(); }

        public IWebElement getCartButton() => cartButton;
        public IWebElement getTotal() => total;
    }
}
