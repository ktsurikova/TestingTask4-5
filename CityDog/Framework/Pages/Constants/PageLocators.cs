using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.Constants
{
    public class PageLocators
    {
        #region Main Page

        public const string AllArticlesXpath = @"*//div[@class='article ']";
        public const string AllDailyArticlesXpath = @"//div[@class='newsBlock']//div[contains(@class, 'newsPost today')]";
        public const string ArticleOfDayXpath = @"//a[text()='OUR CHOICE']/../..//img[@src][1]";
        public const string AllWhereToGoItemsXpath = @"//div[@id='mainTabsContainer']/div[@class='tabsWrapper']/div[@id='tab1']/div[@class='tabSection']";

        #endregion


        #region Article Page

        public const string ArticleTitleXpath = @"//div[contains(@class, 'postPage-title')][3]/div/h1";
        public const string TopArticleDateXpath = @"(//div[contains(@class, 'postPage-rowDate')])[1]";
        public const string BottomArticleDateXpath = @"(//div[contains(@class, 'postPage-rowDate')])[2]";
        public const string ParagrahpsInArticleXPath = @"//div[@class='postPage-content']//p[text()]";
        public const string SuggestedArticlesXPath = @"//div[@class='gallery-slide']//div[@class='postPage-item']";

        #endregion


        #region Where To Go Page

        public const string AllEventsXpath = @"//div[@class='afishaMain-items']/div[contains(@class, 'afishaMain-item')]";

        #endregion
    }
}
