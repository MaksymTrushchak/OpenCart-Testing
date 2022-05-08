using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpencartTesting.Pages
{
    class ProductPage : MainPageHeader
    {
        public WebDriver driver;

        public ProductPage(WebDriver driver) : base(driver)
        {
            this.driver = driver;

        }
    }
}
