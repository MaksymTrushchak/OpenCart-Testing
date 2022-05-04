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

        public SearchResultPage(IWebDriver driver) {

            ListView = driver.FindElement(By.Id("list-view"));
            GridView = driver.FindElement(By.Id("grid-view"));
        
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
