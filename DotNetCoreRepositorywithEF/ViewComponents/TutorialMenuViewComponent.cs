using DotNetCoreRepositorywithEF.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreRepositorywithEF.ViewComponents
{
    public class TutorialMenuViewComponent:ViewComponent
    {
        private readonly ITutorialRepository _tutorial;
        public TutorialMenuViewComponent(ITutorialRepository tutorial)
        {
            _tutorial = tutorial;
        }

        public IViewComponentResult Invoke()
        {
           var tutorials= _tutorial.GetAllTutorials().OrderBy(x=>x.Name);
            return View(tutorials);
        }
    }
}
