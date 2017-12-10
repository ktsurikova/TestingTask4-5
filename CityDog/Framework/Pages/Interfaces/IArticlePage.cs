using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.Interfaces
{
    public interface IArticlePage
    {
        bool IsTextExistInArticle();
        string CommentText(int commentNumber);
        bool IsPictureExistInAtricle();
        bool IsCommentExist();
        string TopArticleDate { get; }
        string BottomArticleDate { get; }
        int CountOfSuggestedArticles { get; }
    }
}
