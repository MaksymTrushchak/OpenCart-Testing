using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.Pages
{
    public class MainPageHeader
    {
        public WebDriver driver;
        public MainPageHeader(WebDriver driver)
        {
            this.driver = driver;
        }

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
        public void ClickShoppingCart() { shoppingCart.Click(); }
        public void ClickCheckout() { checkout.Click(); }
        public void ViewCart() { cartButton.Click(); }

        public IWebElement MyAccountButton
        {
            get
            {
                return driver.FindElement(By.XPath("//a[@class=\"dropdown-toggle\"]"));
            }
        }
        public IWebElement LoginPageButton
        {
            get
            {
                return driver.FindElement(By.XPath("//a[contains(@href, \"http://3.68.27.146/index.php?route=account/login\")]"));
            }
        }
        public IWebElement Logo
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id=\"logo\"]/a/img"));
            }
        }
        public IWebElement WishList
        {
            get
            {
                return driver.FindElement(By.Id("wishlist-total"));
            }
        }
        public IWebElement ListView
        {
            get
            {
                return driver.FindElement(By.XPath("//button[@id='list-view']"));
            }
        }
        public IWebElement AddProduct
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[3]/button[2]"));
            }
        }
        public void MyAccountButtonClick() => MyAccountButton.Click();
        public void LoginPageButtonClick() => LoginPageButton.Click();
        public void addProductClick() => AddProduct.Click();
        public void ListViewClick() => ListView.Click();
        public void LogoClick() => Logo.Click();
        public void WishListClick() => WishList.Click();

        public IWebElement SearchBar
        {
            get
            {
                return driver.FindElement(By.XPath("//button[@type='button'] [@class= 'btn btn-default btn-lg']"));
            }
        }
        public IWebElement SearchButton
        {
            get
            {
                return driver.FindElement(By.Name("search"));
            }
        }
        public void ClickSearchBar() => SearchBar.Click();
        public void SetSearchBarText(string text)
        {
            SearchBar.SendKeys(text);
        }
        public void ClickSearchButton() => SearchButton.Click();
    }
}
