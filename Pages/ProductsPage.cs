using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace OpencartTesting.Pages
{
    class ProductsPage
    {
        public WebDriver driver;
        private IWebElement product1;
        private IWebElement product1Price;
        private IWebElement product2;
        private IWebElement product2Price;
        private IWebElement product3;
        private IWebElement product3Price;
        private IWebElement addToCart;
        private string addToCartXpath;
        private IWebElement deleteFromCart;
        private string deleteFromCartXpath;
        private IWebElement cartButton;
        private string cartButtonXpath;


        public ProductsPage(WebDriver driver)
        {
            this.driver = driver;

            product1 = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]"));
            product1Price = driver.FindElement(By.ClassName("price"));

            //addToCartXpath = "//*[@id='content']/div[2]/div[1]/div/div[2]/div[2]/button[1]";
            addToCartXpath = "#content > div:nth-child(3) > div:nth-child(1) > div > div:nth-child(2) > div.button-group > button:nth-child(1)";
            addToCart = driver.FindElement(By.CssSelector(addToCartXpath));

            deleteFromCartXpath = "//*[@id='cart']/ul/li[1]/table/tbody/tr/td[5]/button";
            deleteFromCart = driver.FindElement(By.XPath(deleteFromCartXpath));

            cartButtonXpath = "//*[@id='cart']/button";
            cartButton = driver.FindElement(By.XPath(cartButtonXpath));

        }
        public IWebElement getAddToCartButton()
        {
            return addToCart;
        }
        public IWebElement getDeleteFromCartButton()
        {
            return deleteFromCart;
        }
        public IWebElement getCartButton()
        {
            return cartButton;
        }
        public string ParseProductPrice()
        {
            return product1Price.Text;
        }
    }
}
