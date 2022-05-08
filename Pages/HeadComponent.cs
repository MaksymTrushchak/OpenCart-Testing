using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpencartTesting.Tools;


namespace OpencartTesting.Pages
{
    public  class HeadComponent
    {
        public IWebElement SearchBar { get; private set; }

        public IWebElement SearchButton { get; private set; }
       

        public HeadComponent(IWebDriver driver)
        {
            
            SearchButton = driver.FindElement(By.XPath("//button[@type='button'] [@class= 'btn btn-default btn-lg']"));
            SearchBar = driver.FindElement(By.Name("search"));
            
        }

        public void ClickSearchBar() => SearchBar.Click();

        public void SetSearchBarText(string text)
        {
            SearchBar.SendKeys(text);
        }
        public void ClickSearchButton() => SearchButton.Click();
    }
}
    







