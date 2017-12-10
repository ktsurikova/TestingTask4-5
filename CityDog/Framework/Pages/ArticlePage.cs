using Framework.Pages.Constants;
using Framework.Pages.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class ArticlePage : Page, IArticlePage
    {
        [FindsBy(How = How.XPath, Using = PageLocators.TopArticleDateXpath)]
        private IWebElement TopArticleDateElement;

        [FindsBy(How = How.XPath, Using = PageLocators.TopArticleDateXpath)]
        private IWebElement BottomArticleDateElement;

        [FindsBy(How = How.XPath, Using = PageLocators.ParagrahpsInArticleXPath)]
        private IList<IWebElement> ParagrahpsInArticle;

        [FindsBy(How = How.XPath, Using = PageLocators.SuggestedArticlesXPath)]
        private IList<IWebElement> SuggestedArticles;



        public ArticlePage()
        {
            PageFactory.InitElements(Driver, this);
            WaitUntilVisible();
        }


        public bool IsTextExistInArticle()
        {
            return ParagrahpsInArticle.Count != 0;
        }

        public string CommentText(int commentNumber)
        {
            throw new NotImplementedException();
        }

        public bool IsPictureExistInAtricle()
        {
            throw new NotImplementedException();
        }

        public bool IsCommentExist()
        {
            throw new NotImplementedException();
        }

        public string TopArticleDate
        {
            get { return TopArticleDateElement.Text; }
        }

        public string BottomArticleDate
        {
            get { return BottomArticleDateElement.Text; }
        }

        public int CountOfSuggestedArticles
        {
            get { return SuggestedArticles.Count; }
        }


        #region Private Methods

        private void WaitUntilVisible()
        {
            WaitUntilElementIsVisible(By.XPath(PageLocators.ArticleTitleXpath));
        }

        #endregion
    }
}
