using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using LoginsPages.PageObject;
using AHeaderComponentsOpencart;
using OpencartTesting.Tools;
using AddWishList.Pages;
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Attributes;

using NUnit.Framework;
using System.Threading;

namespace OpencartTesting.Tests
{
    [TestFixture]
    [AllureNUnit]
    [Category("LoginPage")]
    class LoginTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://localhost/"; }

        [Test, Order(1)]
        [AllureTag("Login")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Igor")]
        public void LoginInTest()
        {

            AHeaderComponents loginPage = new AHeaderComponents(driver);


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
            AHeaderComponents loginPage = new AHeaderComponents(driver);

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
            AHeaderComponents loginPage = new AHeaderComponents(driver);

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
