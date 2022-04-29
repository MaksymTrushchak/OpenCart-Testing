using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenCartTests.Pages;
using OpenCart.Tools;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Tests
{


    [TestFixture]
    [Category("SearchPage")]
    public class SearchPageTest : TestRunner {
        protected override string OpenCartURL { get => "http://localhost"; }



    }




}
