using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpenCartClasses
{
    class ShoppingCartEmpty
    {
        static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://localhost/opencart/upload/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("cart")).Click();

            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
