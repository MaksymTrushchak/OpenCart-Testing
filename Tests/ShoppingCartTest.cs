using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;
using OpencartTesting.Pages;
using OpencartTesting.Tools;
using NUnit.Framework;
using System;
using System.Threading;

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
        }

        [Test]
        static void DeleteFromCartTest(WebDriver driver)
        {
            string expectedResult = "Your shopping cart is empty!";
            string actualResult;

            driver.FindElement(By.LinkText("Phones & PDAs")).Click();

            ProductsPage items = new ProductsPage(driver);

            items.AddProduct1ToCart();
            // Only for Presentation
            Thread.Sleep(500);

            items.AddProduct2ToCart();
            // Only for Presentation
            Thread.Sleep(500);
            
            items.AddProduct3ToCart();
            // Only for Presentation
            Thread.Sleep(500);

            driver.Navigate().GoToUrl("http://192.168.0.100/opencart/upload/index.php?route=checkout/cart");
            ShoppingCart cart = new ShoppingCart(driver);
            Thread.Sleep(500);

            cart.RemoveProduct3();
            cart.RemoveProduct2();
            cart.RemoveProduct1();

            Thread.Sleep(1000);

            actualResult = driver.FindElement(By.CssSelector("#content > p")).Text;
            Assert.AreEqual(expectedResult, actualResult);

            // Only for Presentation
            Thread.Sleep(1000);
            cart.ClickContinue();
        }

        [Test]
        static void RefreshItemsTest(WebDriver driver)
        {
            string expectedResult = "Your shopping cart is empty!";
            string actualResult;

            driver.FindElement(By.LinkText("Phones & PDAs")).Click();

            ProductsPage items = new ProductsPage(driver);

            items.AddProduct1ToCart();
            // Only for Presentation
            Thread.Sleep(500);

            items.AddProduct2ToCart();
            // Only for Presentation
            Thread.Sleep(500);

            items.AddProduct3ToCart();
            // Only for Presentation
            Thread.Sleep(500);

            driver.Navigate().GoToUrl("http://192.168.0.100/opencart/upload/index.php?route=checkout/cart");
            ShoppingCart cart = new ShoppingCart(driver);
            Thread.Sleep(500);

            cart.RemoveProduct3();
            cart.RemoveProduct2();
            cart.RemoveProduct1();

            Thread.Sleep(1000);

            actualResult = driver.FindElement(By.CssSelector("#content > p")).Text;
            Assert.AreEqual(expectedResult, actualResult);

            // Only for Presentation
            Thread.Sleep(1000);
            cart.ClickContinue();
        }

        static void GoToMainPage(WebDriver driver)
        {
            driver.Navigate().GoToUrl("http://192.168.0.100/opencart/upload/");
        }
    }
}