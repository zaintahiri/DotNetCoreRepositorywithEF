using DotNetCoreRepositorywithEF.Models;

namespace DotNetCoreRepositorywithEF.Repository
{
    public interface IArticleRepository
    {
         Article AddAtricle(Article article);
        Article UpdateAtricle(Article article);
        Article DeleteAtricle(int id);
        Article GetAtricle(int id);
        IEnumerable<Article> GetAtricles();
        IEnumerable<Tutorial> GetTutorials();
        IEnumerable<Article> GetAtriclesByTutorialId(int tutorialId);


    }
}
