
using NUnit.Framework;
using OpenCart.Pages;
using OpenCart.Tools;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using OpenQA.Selenium.Chrome;

namespace OpenCart.Tests
{


    [TestFixture]
    [Category("SearchPage")]
    public class SearchPageTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://localhost/index.php?route=product/search"; }


        public void BeforeEachMethod()
        {
            driver = new ChromeDriver(@"C:\Users\maxtr\OneDrive\Робочий стіл\SoftServe\Drivers");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(OpenCartURL);
        }
        [Test]
        public void SearchResultTest()
        {
            string expectedResult = "MacBook";

            string actualResult;
            actualResult = driver.FindElement(By.CssSelector("[href*='http://localhost/macbook?search=mac%20book']")).Text;


            Assert.AreEqual(expectedResult,actualResult);
        }

    }




}
