using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutorizationOpencartPageObject
{
    class AutorizationOpencart 
    {
        private IWebDriver _driver;

        private readonly By _myAccountButton = By.ClassName("dropdown-menu dropdown-menu-right");
        private readonly By _loginPageButton = By.XPath("//a[contains(@href, 'http://localhost/index.php?route=account/login')]");
        private readonly By _loginInput = By.XPath("//input[@name='email']");
        private readonly By _passwordInput = By.XPath("//input[@name='password']");
        private readonly By _enterButton = By.XPath("//input[@value='Login']");

        public AutorizationOpencart(IWebDriver driver)
        {
            _driver = driver;
        }

        public AHeaderComponents Login(string login, string password)
        {
            _driver.FindElement(_myAccountButton).Click();
            _driver.FindElement(_loginPageButton).Click();
            _driver.FindElement(_loginInput).SendKeys(login);
            _driver.FindElement(_passwordInput).SendKeys(password);
            _driver.FindElement(_enterButton).Click();

            return new AHeaderComponents(_driver);
        }
    }
}
