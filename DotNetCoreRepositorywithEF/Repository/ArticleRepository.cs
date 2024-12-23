using DotNetCoreRepositorywithEF.Context;
using DotNetCoreRepositorywithEF.Models;

namespace DotNetCoreRepositorywithEF.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly TutorialDBContext _context;

        public ArticleRepository(TutorialDBContext context)
        {
            _context = context;
        }

        public Article AddAtricle(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
            return article;
        }

        public Article DeleteAtricle(int id)
        {
            var article = _context.Articles.Find(id);
            if (article != null)
            {
                _context.Articles.Remove(article);
                _context.SaveChanges();
            }
            return article;
        }

        public Article GetAtricle(int id)
        {
            var article = _context.Articles.Find(id);
            return article;
        }

        public IEnumerable<Article> GetAtricles()
        {
            return _context.Articles.ToList();
        }

        public IEnumerable<Article> GetAtriclesByTutorialId(int tutorialId)
        {
            var articles= _context.Articles.Where<Article>(x=>x.TutorialId==tutorialId).ToList();
            return articles;
        }

        public Article UpdateAtricle(Article article)
        {
            _context.Articles.Update(article);
            _context.SaveChanges();
            return article; 
        }
    }
}
