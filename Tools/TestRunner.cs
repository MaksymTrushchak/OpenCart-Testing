using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace OpencartTesting.Tools
{
    public abstract class TestRunner
    {
        protected WebDriver driver;
        protected abstract string OpenCartURL { get; }
        
        [SetUp]
        public void BeforeEachMethod()
        {
            driver = new ChromeDriver("/usr/bin/chromedriver");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(OpenCartURL);
        }
       
        [TearDown]
        public void AfterEachMethod() 
        {
            driver.Close();
            driver.Quit();
        }
    }
}
