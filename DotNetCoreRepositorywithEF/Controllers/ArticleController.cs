using DotNetCoreRepositorywithEF.Models;
using DotNetCoreRepositorywithEF.Repository;
using DotNetCoreRepositorywithEF.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            IEnumerable<Article> articles =_repository.GetAtricles();
            return View(articles);
        }
        [HttpGet]
        public IActionResult AddArticle()
        {
            var tutorials=_repository.GetTutorials();
            ViewBag.Tutorials = new SelectList(tutorials, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddArticle(AritcleViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                var tutorials = _repository.GetTutorials();
                ViewBag.Tutorials = new SelectList(tutorials, "TutorialId", "Name");
                return View(viewModel);
            }           

           
             _repository.AddAtricle(new Article {              
                 ArticleTitle= viewModel.ArticleTitle,
                 ArticleContent=viewModel.ArticleContent,
                 TutorialId=viewModel.TutorialId
             });
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult DisplayArticles(int id)
        {
            var articles=_repository.GetAtriclesByTutorialId(id);
            
            return View(articles);
        }


        [HttpGet]
        public IActionResult EditArticle(int id)
        {
            var article=_repository.GetAtricle(id);
            return View(article);     
        }

        [HttpPost]
        public IActionResult EditArticle(AritcleViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            _repository.UpdateAtricle(new Article
            {
                ArticleId= viewModel.ArticleId,
                ArticleTitle = viewModel.ArticleTitle,
                ArticleContent = viewModel.ArticleContent,
                TutorialId = viewModel.TutorialId,
            });
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult DeleteArticle(int id)
        {
            _repository.DeleteAtricle(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
