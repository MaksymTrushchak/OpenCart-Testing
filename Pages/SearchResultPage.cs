using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace OpencartTesting.Pages
{
   public class SearchResultPage
    {
        public IWebElement ListView { get; private set; }

        public IWebElement GridView { get; private set; }

        public IWebElement Product { get; private set; }

        public IWebElement CriteriaBar { get; private set; }

        public IWebElement ProductDescriptionCheck { get; private set; }
        
        public IWebElement SearchButton { get; private set; }

        public SearchResultPage(IWebDriver driver) {

            ListView = driver.FindElement(By.Id("list-view"));
            GridView = driver.FindElement(By.Id("grid-view"));
            Product=driver.FindElement(By.LinkText("MacBook"));
            CriteriaBar = driver.FindElement(By.Id("input-search"));
            ProductDescriptionCheck=driver.FindElement(By.Id("description"));
            SearchButton = driver.FindElement(By.Id("button-search"));
        }


        public void ListViewClick() => ListView.Click();
        public void GridViewClick() => GridView.Click();

        public string GetGridClassName() {
            return GridView.GetAttribute("class");
        }
        public string GetListClassName()
        {
            return ListView.GetAttribute("class");
        }
        public string GetProductName() {

            string name = Product.Text;

            return name;
        }

        public void InputCriteriaBar(string text) {
            CriteriaBar.SendKeys(text);
        }

        public void SearchButtonClick() => SearchButton.Click();
        

        public void DescriptionCheckClick() => ProductDescriptionCheck.Click(); 


        public bool CheckTrueView(string classname) {
            if (classname.Contains("active"))
            {
                return true;
            }
            else {
                return false;
            }
        
        }




    }
}
