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

namespace OpencartTesting.Tests
{


    [TestFixture]
    [Category("SearchPage")]
    public class SearchPageTest : TestRunner
    {
        protected override string OpenCartURL { get => "http://localhost/index.php?route=product/search"; }



        [Test]
        public void SearchResultTest()
        {
            
            string expectedResult = "MacBook";

            HeadComponent Obj = new HeadComponent(driver);


            Obj.SetSearchBarText(expectedResult);
            Obj.ClickSearchButton();


            string actualResult;
            actualResult = driver.FindElement(By.LinkText("MacBook")).Text;


            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GridViewTest() {

            HeadComponent ObjHeadComponet = new HeadComponent(driver);
            ObjHeadComponet.SetSearchBarText("MacBook");
            ObjHeadComponet.ClickSearchButton();

            SearchResultPage Obj = new SearchResultPage(driver);
            Obj.GridViewClick();
            Assert.IsTrue(Obj.CheckTrueView(Obj.GetGridClassName()));

            Obj.ListViewClick();
            Assert.IsTrue(Obj.CheckTrueView(Obj.GetListClassName()));


        }
    }




}
