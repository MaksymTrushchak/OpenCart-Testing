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
            // Only for Presentation
            Thread.Sleep(500);

            items.AddProduct2ToCart();
            // Only for Presentation
            Thread.Sleep(500);

            items.AddProduct3ToCart();
            // Only for Presentation
            Thread.Sleep(500);

            GoToCart(driver);

            Assert.IsNotNull(driver.FindElement(By.XPath("//*[@id='content']/form/div/table/tbody/tr[3]/td[2]")));
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
            // Only for Presentation
            Thread.Sleep(500);

            items.AddProduct2ToCart();
            // Only for Presentation
            Thread.Sleep(500);

            items.AddProduct3ToCart();
            // Only for Presentation
            Thread.Sleep(500);

            GoToCart(driver);
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
            cart.ClickContinue();
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

            // Only for Presentation
            Thread.Sleep(1000);

            for (int i = 0; i < 2; i++)
            {
                items.AddProduct2ToCart();
                Thread.Sleep(500);
            }

            GoToCart(driver);
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