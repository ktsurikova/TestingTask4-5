using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ArticleOfDayTests
{
    [TestFixture, Category("ArticleOfDay")]
    public class ArticleOfDayTests
    {
        private ArticlePage _ariclePage;


        [SetUp]
        public void SetUpMethods()
        {
            var mainPage = new MainPage().OpenMainPage();
            _ariclePage = mainPage.OpenArticleOfDay();
        }


        [Test]
        public void IsTextExist()
        {
            Assert.True(_ariclePage.IsTextExistInArticle(), "Any text wasn't found in the article of the day");
        }


        [Test]
        public void IsTopArticleDateEqualsToBottom()
        {
            Assert.AreEqual(_ariclePage.TopArticleDate, _ariclePage.BottomArticleDate,
                "Top date doesn't equal to bottom date in the article of the day");
        }


        [Test]
        public void IsCountOfSuggestedArticlesEqualsTo()
        {
            Assert.AreEqual(5, _ariclePage.CountOfSuggestedArticles,
                "Count of suggested articles is incorrect in the article of the day");
        }
    }
}
