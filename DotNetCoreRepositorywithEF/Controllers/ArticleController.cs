using DotNetCoreRepositorywithEF.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreRepositorywithEF.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _repository;
        public ArticleController(IArticleRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult DisplayArticles(int id)
        {
            var articles=_repository.GetAtriclesByTutorialId(id);
            return View(articles);
        }
    }
}
