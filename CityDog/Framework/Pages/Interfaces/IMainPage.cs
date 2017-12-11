using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.Interfaces
{
    public interface IMainPage
    {
        ArticlePage OpenArticle(int articleNumber);
        ArticlePage OpenArticleOfDay();
        ArticlePage OpenArticle();
        Page OpenSection(Sections sectionName);
        Page OpenSubsection(Subsections subsectionName);
        void OpenSocialNetwork(SocialNetwork socialNetworkName);
        int CountOfOldArticles { get; }
        int CountOfDailyArticles { get; }
        string MainArticleTitle { get; }
        int CountOfAllWhereToGoItems { get; }
    }
}
