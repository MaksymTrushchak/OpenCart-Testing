using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace OpencartTesting.Pages
{
    class ProductsPage
    {
        public WebDriver driver;
        private List<IWebElement> products = new List<IWebElement>();
        private List<IWebElement> productNames = new List<IWebElement>();
        private IWebElement productPrice;
        private IWebElement addToCart;
        private IWebElement deleteFromCart;
        private IWebElement cartButton;

        public ProductsPage(WebDriver driver)
        {
            this.driver = driver;
            
            products.Add(driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]")));
            productNames.Add(driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[2]/div[1]/h4/a")));
            productPrice = products[0].FindElement(By.ClassName("price"));
            addToCart = products[0].FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[2]/div[2]/button[1]"));
            deleteFromCart = driver.FindElement(By.XPath("//*[@id='cart']/ul/li[1]/table/tbody/tr/td[5]/button"));
            cartButton = driver.FindElement(By.XPath("//*[@id='cart']/button"));
        }

        public void ClickAddToCart()
        {
            addToCart.Click();
        }
        public void ClickDeleteFromCart()
        {
            deleteFromCart.Click();
        }
        public void ClickCartButton()
        {
            cartButton.Click();
        }
        public string ParseProductPrice()
        {
            return productPrice.Text;
        }
    }
}
