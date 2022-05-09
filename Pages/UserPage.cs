using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using AHeaderComponentsOpencart;
using LoginsPages.PageObject;


namespace UserPages.PageObject
{
    public class UserPage : LoginPage
    {
        

        
        public UserPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;            
        }
        public IWebElement WishList
        {
            get
            {
                return driver.FindElement(By.Id("wishlist-total"));
            }
        } 
        public void WishListClick() => WishList.Click();

        
    }
}
