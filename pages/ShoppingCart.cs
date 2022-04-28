using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ShoppingCartFunctionals
{
    class ShoppingCart
    {
        static void Main()
        {
            WebDriver driver = new ChromeDriver();
           
            driver.Navigate().GoToUrl("http://localhost/opencart/upload/");
            driver.Manage().Window.Maximize();

            IWebElement shoppingCart = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[4]"));
            IWebElement cart = driver.FindElement(By.XPath("//*[@id='cart']/button"));
            IWebElement total = driver.FindElement(By.CssSelector("#cart-total"));
            IWebElement checkout = driver.FindElement(By.XPath("//*[@id='top - links']/ul/li[5]"));

            driver.Quit();
        }
    }
}
