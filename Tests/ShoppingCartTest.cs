using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;

using NUnit.Framework;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Allure.Commons;

using OpencartTesting.Pages;
using OpencartTesting.Tools;

using System;
using System.Threading;

namespace OpencartTesting.Tests
{
    [TestFixture]
    [AllureNUnit]
    [Category("ShoppingCart")]
    class ShoppingCartTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://3.68.27.146/"; }

        [AllureTag("AddToCart")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Artur")]
        [Test]
        public void AddToCartTest()
        {
            GoToPhonesAndPDAs(driver);
            ProductsPage items = new ProductsPage(driver);

            items.AddProduct1ToCart();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            items.AddProduct2ToCart();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            items.AddProduct3ToCart();
            GoToCart(driver);

            Assert.IsNotNull(driver.FindElement(By.XPath("//table/tbody/tr[3]/td[2]/a")));
        }

        [AllureTag("DeleteFromCart")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Artur")]
        [Test]
        public void DeleteFromCartTest()
        {
            string expectedResult = "Your shopping cart is empty!";
            string actualResult = "";

            GoToPhonesAndPDAs(driver);
            ProductsPage items = new ProductsPage(driver);

            items.AddProduct1ToCart();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            items.AddProduct2ToCart();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            items.AddProduct3ToCart();

            GoToCart(driver);
            ShoppingCart cart = new ShoppingCart(driver);

            cart.RemoveProduct3();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            cart = new ShoppingCart(driver);
            cart.RemoveProduct2();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            driver.Navigate().Refresh();
            cart.RemoveProduct1();

            actualResult = driver.FindElement(By.CssSelector("#content > p")).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [AllureTag("RefreshCart")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Artur")]
        [Test]
        public void RefreshItemsTest()
        {
            string expectedResult = "Success: You have modified your shopping cart!";
            string actualResult;

            GoToPhonesAndPDAs(driver);
            ProductsPage items = new ProductsPage(driver);

            for (int i = 0; i < 2; i++)
            {
                items.AddProduct2ToCart();
                Thread.Sleep(500);
            }

            GoToCart(driver);
            ShoppingCart cart = new ShoppingCart(driver);
            cart.RefreshProduct();

            actualResult = driver.FindElement(By.XPath("/html/body/div[2]/div[1]")).Text;
            StringAssert.Contains(expectedResult, actualResult);
        }
        
        static void GoToMainPage(WebDriver driver)
        {
            driver.Navigate().GoToUrl("http://3.68.27.146/");
        }
        static void GoToCart(WebDriver driver)
        {
            driver.Navigate().GoToUrl("http://3.68.27.146/index.php?route=checkout/cart");
        }
        static void GoToPhonesAndPDAs(WebDriver driver)
        {
            driver.Navigate().GoToUrl("http://3.68.27.146/smartphone");
        }
    }
}