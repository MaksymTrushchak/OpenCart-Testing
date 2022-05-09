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
    [Category("WishList")]
    class AddWishList : TestRunner
    {
        protected override string OpenCartURL { get => "http://localhost/"; }


        [Test]
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
            Thread.Sleep(2000); // For Presentation ONLY

            loginPage.addProductClick();
            Thread.Sleep(2000); // For Presentation ONLY

            loginPage.WishListClick();
            Thread.Sleep(2000); // For Presentation ONLY

            string expectedResult = "My Wish List";
            string actualResult = driver.FindElement(By.XPath("//*[@id='content']/h2")).Text;

            Assert.AreEqual(expectedResult, actualResult);
        }
    } 

}
