using DotNetCoreRepositorywithEF.Context;
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
    }
}
