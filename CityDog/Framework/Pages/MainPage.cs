using Framework.Pages.Constants;
using Framework.Pages.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class MainPage : Page, IMainPage
    {
        [FindsBy(How = How.XPath, Using = PageLocators.AllArticlesXpath)]
        public IList<IWebElement> AllArticles;

        [FindsBy(How = How.XPath, Using = PageLocators.AllDailyArticlesXpath)]
        public IList<IWebElement> AllDailyArticles;

        [FindsBy(How = How.XPath, Using = PageLocators.ArticleOfDayXpath)]
        private IWebElement ArticleOfDay;

        [FindsBy(How = How.XPath, Using = PageLocators.AllWhereToGoItemsXpath)]
        public IList<IWebElement> WhereToGoItems;


        public MainPage()
        {
            PageFactory.InitElements(Driver, this);
        }


        public ArticlePage OpenArticle(int articleNumber)
        {
            throw new NotImplementedException();
        }

        public Page OpenSection(Sections sectionName)
        {
            GetSectionHref(sectionName).Click();

            switch (sectionName)
            {
                case Sections.WhereToGo:
                    return new WhereToGoPage();

                default:
                    throw new NotImplementedException();
            }
        }

        public Page OpenSubsection(Subsections subsectionName)
        {
            throw new NotImplementedException();
        }

        public void OpenSocialNetwork(SocialNetwork socialNetworkName)
        {
            throw new NotImplementedException();
        }

        public int CountOfOldArticles
        {
            get
            {
                return AllArticles.Count;
            }
        }

        public int CountOfDailyArticles
        {
            get { return AllDailyArticles.Count; }
        }

        public string MainArticleTitle
        {
            get { throw new NotImplementedException(); }
        }

        public ArticlePage OpenArticleOfDay()
        {
            ArticleOfDay.Click();

            return new ArticlePage();
        }


        public int CountOfAllWhereToGoItems
        {
            get { return WhereToGoItems.Count; }
        }


        #region Private Methods

        private IWebElement GetSectionHref(Sections sectionName)
        {
            string urlPart;

            switch (sectionName)
            {
                case Sections.WhereToGo:
                    urlPart = @"Куда пойти";
                    break;

                default:
                    throw new NotImplementedException();
            }

            string hrefXpath = String.Format(@"//div[@class='menuBlock']/ul[contains(@class, 'mainMenu ')]//a[contains(text(), '{0}')]", urlPart);
            return Driver.FindElement(By.XPath(hrefXpath));
        }

        #endregion
    }


    public enum Sections
    {
        Journal,
        Knowledge,
        WhereToGo,
        HealthyLifestyle,
        Minsk1067,
        HotDog
    }

    public enum Subsections
    {

    }

    public enum SocialNetwork
    {

    }
}
