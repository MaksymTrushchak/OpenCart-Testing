using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using LoginsPages.PageObject;
using AHeaderComponentsOpencart;
using OpencartTesting.Tools;
using UserPages.PageObject;
using AddWishList.Pages;

using NUnit.Framework;
using System.Threading;

namespace OpencartTesting.Tests
{
    [TestFixture]
    [Category("LoginPage")]
    class LoginTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://localhost/"; }

        [Test]
        public void LoginInTest()
        {
            AHeaderComponents loginPage = new AHeaderComponents(driver);


            loginPage.driver.Manage().Window.Maximize();

            loginPage.MyAccountButtonClick();

            Thread.Sleep(2000); // For Presentation ONLY

            loginPage.LoginPageButtonClick();
            Thread.Sleep(2000); // For Presentation ONLY

            LoginPage newLoginPage = new LoginPage(driver);
            newLoginPage.LoginInputClick();
            newLoginPage.LoginInputClear();

            newLoginPage.LoginInputSendKeys("tester@gmail.com");
            Thread.Sleep(2000); // For Presentation ONLY

            newLoginPage.PasswordInputClick();
            newLoginPage.PasswordInputClear();

            newLoginPage.PasswordInputSendKeys("qazzaq");
            Thread.Sleep(2000); // For Presentation ONLY

            newLoginPage.EnterButtonClick();
            Thread.Sleep(4000); // For Presentation ONLY



        }
        [Test]
        public void addWishListTest()
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
            driver.Navigate().GoToUrl("http://localhost/index.php?route=common/home");
            Thread.Sleep(4000); // For Presentation ONLY
            driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[3]/button[2]")).Click();
            Thread.Sleep(4000); // For Presentation ONLY
            loginPage.WishListClick();
            Thread.Sleep(4000); // For Presentation ONLY

        }
        [Test]
        public void removeWishListTest()
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
            driver.Navigate().GoToUrl("http://localhost/index.php?route=common/home");
            driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/div/div[3]/button[2]")).Click();

            loginPage.WishListClick();

            Thread.Sleep(2000); // For Presentation ONLY
            UserPage userPage = new UserPage(driver);
            userPage.WishListClick();

            WishListPage addWishList = new WishListPage(driver);
            Thread.Sleep(2000); // For Presentation ONLY
            addWishList.RemoveButtonClick();
            Thread.Sleep(2000); // For Presentation ONLY
            addWishList.ContinueButtonClick();
            Thread.Sleep(2000); // For Presentation ONLY
        }
    }
    
}