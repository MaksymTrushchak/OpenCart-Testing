using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestOpencart
{
    public abstract class AHeaderComponents
    {
        protected IWebDriver driver;

        public IWebElement TitleLabel { get; private set; }
        public IWebElement WishList { get; private set; }
        public IWebElement MyAccount { get; private set; }
        
        protected AHeaderComponents(IWebDriver driver)
        {
            this.driver = driver;
            TitleLabel = driver.FindElement(By.XPath("//img[@title='Your Store']"));
        }
        public void GetTitleLable()
        {
            TitleLabel.Click();
        }
    }
}

