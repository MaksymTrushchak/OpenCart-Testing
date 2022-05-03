using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AHeaderComponentsOpencart
{
    class AHeaderComponents
    {
        private IWebDriver _driver;
        
        private readonly By _myAccount = By.ClassName("dropdown-menu dropdown-menu-right");
        private readonly By _loginPage = By.XPath("//a[contains(@href, 'http://localhost/index.php?route=account/login')]");
        private readonly By _wishList = By.ClassName("hidden-xs hidden-sm hidden-md");

        public AHeaderComponents(IWebDriver driver)
        {
            _driver = driver;
        }

        public AutorizationPageObject LoginPage()
        {
            _driver.FindElement(_myAccount).Click();
            _driver.FindElement(_loginPage).Click();

            return new AutorizationPageObject(_driver);
        }
        public WishListPageObject WishList()
        {
            _driver.FindElement(_wishList).Click();

            return new WishListPageObject(_driver);
        }
    }
}

