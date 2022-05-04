using NUnit.Framework;
using OpencartTesting.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartTesting.Tools
{
    public abstract class TestRunner
    {
        protected IWebDriver driver;

        protected abstract string OpenCartURL { get; }
        
        [SetUp]
        public void BeforeEachMethod()
        {
            driver = new ChromeDriver(@"C:\Users\maxtr\OneDrive\Робочий стіл\SoftServe\Drivers");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(OpenCartURL);
        }
       
        [TearDown]
        public void AfterEachMethod() {
            driver.Close();
            driver.Quit();
        }

     



    }




}
