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
        protected ChromeOptions options = new ChromeOptions();
        
        [SetUp]
        public void BeforeEachMethod()
        {
            options.BinaryLocation = "/usr/bin/chromium"; // binary path to find browser
            options.AddArguments("start-maximized"); // open Browser in maximized mode
            options.AddArguments("disable-infobars"); // disabling infobars
            options.AddArguments("--disable-extensions"); // disabling extensions
            options.AddArguments("--disable-gpu"); // applicable to windows os only
            options.AddArguments("--disable-dev-shm-usage"); // overcome limited resource problems
            options.AddArguments("--no-sandbox"); // Bypass OS security model
            options.AddArgument("headless");

            driver = new ChromeDriver("/usr/bin/");
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
