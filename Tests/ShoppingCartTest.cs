using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;
using OpencartTesting.Pages;
using OpencartTesting.Tools;
using NUnit.Framework;
using System;

namespace OpencartTesting.tests
{
    [Category("ShoppingCart")]
    class ShoppingCartTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://192.168.0.100/opencart/upload/"; }

        [Test]
        static void Main()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            GoToMainPage(driver);
            driver.Manage().Window.Maximize();

            DeleteFromCartTest(driver);
            //GoToMainPage(driver);

            //RefreshItemsTest(driver);
        }

        [Test]
        static void DeleteFromCartTest(WebDriver driver)
        {
            driver.FindElement(By.LinkText("Phones & PDAs")).Click();

            ProductsPage items = new ProductsPage(driver);

            items.getAddToCartButton().Click();

            driver.Navigate().Refresh();

            items.getCartButton().Click();
            items.getDeleteFromCartButton().Click();

            items.getCartButton().Click();

            string expectedResult = "Your shopping cart is empty!";
            string actualResult = driver.FindElement(By.XPath("//*[@id='cart']/ul/li/p")).Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        static void RefreshItemsTest(WebDriver driver)
        {
            driver.FindElement(By.LinkText("Phones & PDAs")).Click();

            ProductsPage items = new ProductsPage(driver);

            items.getAddToCartButton().Click();
            
        }

        static void GoToMainPage(WebDriver driver)
        {
            driver.Navigate().GoToUrl("http://192.168.0.100/opencart/upload/");
        }
    }
}