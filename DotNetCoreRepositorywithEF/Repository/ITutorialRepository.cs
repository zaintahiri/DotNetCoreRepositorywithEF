using DotNetCoreRepositorywithEF.Models;

namespace DotNetCoreRepositorywithEF.Repository
{
    public interface ITutorialRepository
    {
        Tutorial Add(Tutorial tutorial);
        Tutorial Delete(int id);
        IEnumerable<Tutorial> GetAllTutorials();
        Tutorial GetTutorial(int id);

        Tutorial Update(int id, Tutorial tutorial);

    }
}
