﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ShoppingCartFunctionals
{
    class ShippingCartEmpty
    {
        static void EmptyCart()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost/opencart/upload/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='cart']/button")).Click();

            driver.Quit();
        }
    }
}