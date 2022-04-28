using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Opencart_CartFunctionals
{
    class ShoppingCartEmpty
    {
        static void Nain()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost/opencart/upload/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='cart']/button")).Click();

            driver.Quit();
        }
    }
}
