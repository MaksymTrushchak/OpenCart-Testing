using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpencartTesting.Pages;
using OpencartTesting.Tools;
using NUnit.Framework;

namespace OpencartTesting.tests
{
    [TestFixture]
    [Category("ShoppingCart")]
    class ShoppingCartTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://localhost/index.php?route=product/search"; }

        [Test]
        static void AddToCartTest()
        {
            ShoppingCart MainPage = new ShoppingCart(driver);

            MainPage.driver.Navigate().GoToUrl("http://localhost/opencart/upload/");
            MainPage.driver.Manage().Window.Maximize();

            MainPage.driver.FindElement(By.LinkText("Phones & PDAs")).Click();

            MainPage.driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[2]/div[2]/button[1]")).Click();
            MainPage.driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[2]/div/div[2]/div[2]/button[1]")).Click();
            MainPage.driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[3]/div/div[2]/div[2]/button[1]")).Click();

            MainPage.getCartButton().Click();

            string expectedResult = "3 item(s) - 457.57€";
            string actualResult = MainPage.getTotal();

            StringAssert.Equals(expectedResult, actualResult);
        }
    }
}