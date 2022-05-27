using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpencartTesting.Tools;
using OpencartTesting.Pages;

using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace OpencartTesting.Tests
{
    [TestFixture]
    [AllureNUnit]
    [Category("SearchPage")]
    public class SearchPageTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://3.68.27.146/index.php?route=product/search"; }


        [Test]
        [AllureTag("SearchPage")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("MaxTr")]
        public void SearchResultTest()
        {
            string expectedResult = "MacBook";
            SearchResultPage Obj = new SearchResultPage(driver);


            Obj.SetSearchBarText(expectedResult);
            Obj.ClickSearchButton();

            SearchResultPage resultpage = new SearchResultPage(driver);


            string actualResult;
            actualResult = resultpage.GetProductName();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [AllureTag("SearchPage")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("MaxTr")]
        public void GridViewTest()
        {
            SearchResultPage ObjHeadComponet = new SearchResultPage(driver);
            ObjHeadComponet.SetSearchBarText("MacBook");
            ObjHeadComponet.ClickSearchButton();
            SearchResultPage Obj = new SearchResultPage(driver);
            
            Obj.GridViewClick();
            Assert.IsTrue(Obj.CheckTrueView(Obj.GetGridClassName()));
           
            Obj.ListViewClick();
            Assert.IsTrue(Obj.CheckTrueView(Obj.GetListClassName()));
        }
        [Test]
        [AllureTag("SearchPage")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("MaxTr")]
        public void SearchInDescriptionTest()
        {
            string expectedResult = "MacBook";
            SearchResultPage resultpage = new SearchResultPage(driver);

            resultpage.InputCriteriaBar("intel");
            resultpage.DescriptionCheckClick();
            resultpage.SearchButtonClick();
            string actualResult = resultpage.GetProductName();

            Assert.AreEqual(expectedResult, actualResult);
        }

    }




}
