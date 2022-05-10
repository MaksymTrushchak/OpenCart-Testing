using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AHeaderComponentsOpencart;


namespace AddWishList.Pages
{
    public class WishListPage: AHeaderComponents
    {
        


        public WishListPage(IWebDriver driver): base (driver)
        {
            this.driver = driver;
        }

        public IWebElement AddToCart
        {get
            {
                return driver.FindElement(By.XPath("//button[@data-original-title='Add to Cart']"));
            }
        }
            public IWebElement RemoveButton
        {get
            {
                return driver.FindElement(By.XPath("//*[@id='content']/div[1]/table/tbody/tr/td[6]/a/i"));
            }
        }
            public IWebElement ContinueButton
        {get
            {
                return driver.FindElement(By.XPath("//*[@id='content']/div/div/a"));
            }
        }

        
        public void AddToCartClick() => AddToCart.Click();
        public void RemoveButtonClick() => RemoveButton.Click();
        public void ContinueButtonClick() => ContinueButton.Click();
       

    }
}
