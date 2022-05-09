using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;
using OpencartTesting.Pages;
using OpencartTesting.Tools;
using NUnit.Framework;
using System;
using System.Threading;

namespace OpencartTesting.Tests
{
    [TestFixture]
    [Category("ShoppingCart")]
    class ShoppingCartTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://192.168.0.100/opencart/upload/"; }

        static void Main()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            GoToMainPage(driver);
            driver.Manage().Window.Maximize();

            AddToCartTest(driver);
            // Only for Presentation
            Thread.Sleep(2000);

            DeleteFromCartTest(driver);
            // Only for Presentation
            Thread.Sleep(2000);

            RefreshItemsTest(driver);
            // Only for Presentation
            Thread.Sleep(2000);

            driver.Close();
            driver.Quit();
        }

        [Test]
        static void AddToCartTest(WebDriver driver) 
        {
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
        }

        [Test]
        static void DeleteFromCartTest(WebDriver driver)
        {
            string expectedResult = "Your shopping cart is empty!";
            string actualResult = "";

            driver.Navigate().GoToUrl("http://192.168.0.100/opencart/upload/index.php?route=checkout/cart");
            ShoppingCart cart = new ShoppingCart(driver);
            // Only for Presentation
            Thread.Sleep(500);

            cart.RemoveProduct3();
            cart.RemoveProduct2();
            cart.RemoveProduct1();
            // Only for Presentation
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
            string expectedResult = "Success: You have modified your shopping cart!";
            string actualResult;

            GoToMainPage(driver);
            driver.FindElement(By.LinkText("Phones & PDAs")).Click();
            ProductsPage items = new ProductsPage(driver);

            // Only for Presentation
            Thread.Sleep(1000);

            for (int i = 0; i < 2; i++)
            {
                items.AddProduct2ToCart();
                Thread.Sleep(500);
            }

            driver.Navigate().GoToUrl("http://192.168.0.100/opencart/upload/index.php?route=checkout/cart");
            ShoppingCart cart = new ShoppingCart(driver);
            cart.RefreshProduct();

            try
            {
                actualResult = cart.getCartUpdatedMessage();
                StringAssert.Contains(expectedResult, actualResult);
            }
            catch (ArgumentException) { }
        }

        static void GoToMainPage(WebDriver driver)
        {
            driver.Navigate().GoToUrl("http://192.168.0.100/opencart/upload/");
        }
    }
}