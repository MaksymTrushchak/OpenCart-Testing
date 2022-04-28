using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ShoppingCartFunctionals
{
    class RefreshCartItem
    {
        static void Refresh()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost/opencart/upload/index.php?route=checkout/cart");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[1]/td[4]/div/span/button[1]")).Click();

            driver.Quit();
        }
    }
}
