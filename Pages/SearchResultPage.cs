using OpenQA.Selenium;
using OpencartTesting.Tools;

namespace OpencartTesting.Pages
{
    public class SearchResultPage : TestRunner
    {
        protected override string OpenCartURL { get => "http://localhost/index.php?route=product/search"; }

        public IWebElement ListView
        {
            get
            {
                return driver.FindElement(By.XPath("//button[@id='list-view']"));
            }
        }

        public IWebElement GridView
        {
            get
            {
                return driver.FindElement(By.Id("grid-view"));
            }
        }

        public IWebElement Product
        {
            get
            {
                return driver.FindElement(By.LinkText("MacBook"));
            }
        }

        public IWebElement CriteriaBar
        {
            get
            {
                return driver.FindElement(By.Id("input-search"));
            }
        }

        public IWebElement ProductDescriptionCheck
        {
            get
            {
                return driver.FindElement(By.Id("description"));
            }
        }

        public IWebElement SearchButton
        {
            get
            {
                return driver.FindElement(By.Id("button-search"));
            }
        }

        public SearchResultPage(IWebDriver driver)
        {

            this.driver = driver;
        }

        public void ListViewClick() => ListView.Click();
        public void GridViewClick() => GridView.Click();

        public string GetGridClassName()
        {
            return GridView.GetAttribute("class");
        }
        public string GetListClassName()
        {
            return ListView.GetAttribute("class");
        }
        public string GetProductName()
        {

            string name = Product.Text;

            return name;
        }

        public void InputCriteriaBar(string text)
        {
            CriteriaBar.Click();
            CriteriaBar.SendKeys(text);
        }

        public void SearchButtonClick() => SearchButton.Click();


        public void DescriptionCheckClick() => ProductDescriptionCheck.Click();


        public bool CheckTrueView(string classname)
        {
            if (classname.Contains("active"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}