using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using LoginsPages.PageObject;
using AHeaderComponentsOpencart;
using OpencartTesting.Tools;
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
            Thread.Sleep(2000); // For Presentation ONLY

            string expectedResult = "My Account";
            string actualResult = driver.FindElement(By.XPath("//*[@id='content']/h2[1]")).Text;

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
