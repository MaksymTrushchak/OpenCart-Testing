using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpencartTesting.Tools;


namespace AHeaderComponentsOpencart
{
    public class AHeaderComponents
    {
        public IWebDriver driver;


        public AHeaderComponents(IWebDriver driver)
        {
            this.driver = driver;
        }


        public IWebElement MyAccountButton
        {
            get
            {
                return driver.FindElement(By.XPath("//a[@class=\"dropdown-toggle\"]"));
            }
        }
        public IWebElement LoginPageButton
        {
            get
            {
                return driver.FindElement(By.XPath("//a[contains(@href, \"http://localhost/index.php?route=account/login\")]"));
            }
        }

        public IWebElement Logo
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id=\"logo\"]/a/img"));
            }
        }
        public IWebElement WishList
        {
            get
            {
                return driver.FindElement(By.Id("wishlist-total"));
            }
        }
        public IWebElement ListView
        {
            get
            {
                return driver.FindElement(By.XPath("//button[@id='list-view']"));
            }
        }
        public void MyAccountButtonClick() => MyAccountButton.Click();
        public void LoginPageButtonClick() => LoginPageButton.Click();

        public void ListViewClick() => ListView.Click();
        public void LogoClick() => Logo.Click();
   
        public void WishListClick() => WishList.Click();
    }
    

        
    
}

