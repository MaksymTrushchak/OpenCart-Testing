using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ShoppingCartFunctionals;

namespace ShoppingCartFunctionals.tests
{
    class ShoppingCartTest
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
            
            driver.FindElement(By.LinkText("Phones & PDAs")).Click();

            driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[2]/div[2]/button[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[2]/div/div[2]/div[2]/button[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[3]/div/div[2]/div[2]/button[1]")).Click();

            cart.Click();

            driver.Quit();
        }
    }
}
