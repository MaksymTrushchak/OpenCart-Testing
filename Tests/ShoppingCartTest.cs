using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpencartTesting.Pages;
using OpencartTesting.Tools;
using NUnit.Framework;
using System;

namespace OpencartTesting.tests
{
    [TestFixture]
    [Category("ShoppingCart")]
    class ShoppingCartTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://192.168.0.100/opencart/upload/"; }

        [Test]
        static void Main()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("http://192.168.0.100/opencart/upload/");
            driver.Manage().Window.Maximize();

            DeleteFromCartTest(driver);
        }

        [Test]
        static void DeleteFromCartTest(WebDriver driver)
        {
            driver.FindElement(By.LinkText("Phones & PDAs")).Click();

            ProductsPage items = new ProductsPage(driver);

            items.ClickAddToCart();

            items.ClickCartButton();
            items.ClickDeleteFromCart();
            items.ClickCartButton();

            string expectedResult = "Your shopping cart is empty!";
            string actualResult = driver.FindElement(By.XPath("//*[@id='cart']/ul/li/p")).Text;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}