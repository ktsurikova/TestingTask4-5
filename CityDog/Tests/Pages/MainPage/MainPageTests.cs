using Framework;
using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.MainPageTests
{
    [TestFixture, Category("MainPage")]
    public class MainPageTests
    {
        private MainPage _mainPage;


        [SetUp]
        public void SetUpMethods()
        {
            _mainPage = new MainPage().OpenMainPage();
        }


        [Test]
        public void ArticlesExistOnPage()
        {
            Assert.Greater(MainPage.CountOfOldArticles, 0, "No articles were found on the main page");
        }


        [Test]
        public void DailyArticlesExistOnPage()
        {
            Assert.Greater(MainPage.CountOfDailyArticles, 0, "No daily articles were found on the main page");
        }


        [Test]
        public void ToGoItemsCountEqualsTo()
        {
            Assert.AreEqual(4, MainPage.CountOfAllWhereToGoItems, "Count of 'Where to go' items is incorrect on the main page");
        }


        #region Private Methods

        private MainPage MainPage
        {
            get
            {
                return _mainPage;
            }
        }

        #endregion
    }
}
