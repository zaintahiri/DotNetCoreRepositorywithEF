using DotNetCoreRepositorywithEF.Context;
using DotNetCoreRepositorywithEF.Models;
using DotNetCoreRepositorywithEF.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreRepositorywithEF.Controllers
{
    public class TutorialController : Controller
    {
        private readonly ITutorialRepository _repository;

        public TutorialController(ITutorialRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
           var allTutorials= _repository.GetAllTutorials();
            return View(allTutorials);
        }

        public IActionResult AddTutorial()
        {         
            return View();
        }

        [HttpPost]
        public IActionResult AddTutorial(Tutorial tutorial)
        {
            if(!ModelState.IsValid)
                return View(tutorial);

            var result=_repository.Add(tutorial);
            return  RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult EditTutorial(int id)
        {
            var tutorial =_repository.GetTutorial(id);
            return View(tutorial);
        }

        [HttpPost]
        public IActionResult EditTutorial(Tutorial tutorial)
        {
            var result = _repository.Update(tutorial);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult DeleteTutorial(int id)
        {
            var result = _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
