using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Pages;
using NUnit.Framework;

namespace Tests.Articles
{
    [TestFixture, Category("ArticleOfDay")]
    public class ArticleTests
    {
        private ArticlePage _ariclePage;

        [SetUp]
        public void SetUpMethods()
        {
            var mainPage = new MainPage().OpenMainPage();
            _ariclePage = mainPage.OpenArticle();
        }


        [Test]
        public void IsTextExist()
        {
            Assert.True(_ariclePage.IsTextExistInArticle(), "Any text wasn't found in the article");
        }


        [Test]
        public void IsTopArticleDateEqualsToBottom()
        {
            Assert.AreEqual(_ariclePage.TopArticleDate, _ariclePage.BottomArticleDate,
                "Top date doesn't equal to bottom date in the article");
        }
    }
}
