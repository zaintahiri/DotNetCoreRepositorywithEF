using DotNetCoreRepositorywithEF.Context;
using DotNetCoreRepositorywithEF.Models;

namespace DotNetCoreRepositorywithEF.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly TutorialDBContext _context;
        public TutorialRepository(TutorialDBContext context)
        {
            _context = context;
        }
        //public TutorialRepository()
        //{
        //    _tutorials = new List<Tutorial>()
        //    {
        //        new Tutorial{Id=1,Name="C#", Description="This is C# Tutorial" },
        //        new Tutorial{Id=1,Name="Java", Description="This is JAVA Tutorial" },
        //        new Tutorial{Id=1,Name="VB.NET", Description="This is VB.NET Tutorial" },
        //    };
        //}
        public Tutorial Add(Tutorial tutorial)
        {
            throw new NotImplementedException();
        }

        public Tutorial Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tutorial> GetAllTutorials()
        {
            return _context.Tutorials.ToList();
        }

        public Tutorial GetTutorial(int id)
        {
            throw new NotImplementedException();
        }

        public Tutorial Update(int id, Tutorial tutorial)
        {
            throw new NotImplementedException();
        }
    }
}
