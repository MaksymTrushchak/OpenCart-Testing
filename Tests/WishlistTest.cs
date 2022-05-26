using OpenQA.Selenium;
using Allure.Commons;
using NUnit.Framework;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

using OpencartTesting.Pages;
using OpencartTesting.Tools;

namespace OpencartTesting.Tests
{
    [TestFixture]
    [AllureNUnit]
    [Category("LoginPage")]
    class WishlistTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://3.68.27.146/"; }

        [Test, Order(1)]
        [AllureTag("Login")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Igor")]
        public void LoginInTest()
        {
            MainPageHeader loginPage = new MainPageHeader(driver);
            loginPage.driver.Manage().Window.Maximize();

            loginPage.MyAccountButtonClick();
            //Thread.Sleep(2000); // For Presentation ONLY

            loginPage.LoginPageButtonClick();
            //Thread.Sleep(2000); // For Presentation ONLY

            LoginPage newLoginPage = new LoginPage(driver);
            newLoginPage.LoginInputClick();
            newLoginPage.LoginInputClear();

            newLoginPage.LoginInputSendKeys("tester@gmail.com");
            //Thread.Sleep(2000); // For Presentation ONLY

            newLoginPage.PasswordInputClick();
            newLoginPage.PasswordInputClear();

            newLoginPage.PasswordInputSendKeys("qazzaq");
            //Thread.Sleep(2000); // For Presentation ONLY

            newLoginPage.EnterButtonClick();
            //Thread.Sleep(2000); // For Presentation ONLY

            string expectedResult = "My Account";
            string actualResult = driver.FindElement(By.XPath("//*[@id='content']/h2[1]")).Text;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test, Order(2)]
        [AllureTag("Login")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Igor")]
        public void AddWishListTest()
        {
            MainPageHeader loginPage = new MainPageHeader(driver);

            loginPage.driver.Manage().Window.Maximize();

            loginPage.MyAccountButtonClick();

            loginPage.LoginPageButtonClick();

            LoginPage newLoginPage = new LoginPage(driver);

            newLoginPage.LoginInputClick();
            newLoginPage.LoginInputClear();
            newLoginPage.LoginInputSendKeys("tester@gmail.com");

            newLoginPage.PasswordInputClick();
            newLoginPage.PasswordInputClear();
            newLoginPage.PasswordInputSendKeys("qazzaq");


            newLoginPage.EnterButtonClick();
            loginPage.LogoClick();
            //Thread.Sleep(2000); // For Presentation ONLY

            loginPage.addProductClick();
            //Thread.Sleep(2000); // For Presentation ONLY

            loginPage.WishListClick();
            //Thread.Sleep(2000); // For Presentation ONLY

            string expectedResult = "My Wish List";
            string actualResult = driver.FindElement(By.XPath("//*[@id='content']/h2")).Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Order(3)]
        [AllureTag("Login")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Igor")]
        public void RemoveWishListTest()
        {
            MainPageHeader loginPage = new MainPageHeader(driver);

            loginPage.driver.Manage().Window.Maximize();

            loginPage.MyAccountButtonClick();

            loginPage.LoginPageButtonClick();

            LoginPage newLoginPage = new LoginPage(driver);

            newLoginPage.LoginInputClick();
            newLoginPage.LoginInputClear();
            newLoginPage.LoginInputSendKeys("tester@gmail.com");

            newLoginPage.PasswordInputClick();
            newLoginPage.PasswordInputClear();
            newLoginPage.PasswordInputSendKeys("qazzaq");


            newLoginPage.EnterButtonClick();
            //Thread.Sleep(2000); // For Presentation ONLY
            loginPage.LogoClick();
            //Thread.Sleep(2000); // For Presentation ONLY
            loginPage.addProductClick();
            //Thread.Sleep(2000); // For Presentation ONLY
            loginPage.WishListClick();

            //Thread.Sleep(2000); // For Presentation ONLY
            loginPage.WishListClick();

            WishListPage addWishList = new WishListPage(driver);
            //Thread.Sleep(2000); // For Presentation ONLY
            addWishList.RemoveButtonClick();
            //Thread.Sleep(2000); // For Presentation ONLY

            string expectedResult = "Your wish list is empty.";
            string actualResult = driver.FindElement(By.XPath("//*[@id='content']/p")).Text;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}