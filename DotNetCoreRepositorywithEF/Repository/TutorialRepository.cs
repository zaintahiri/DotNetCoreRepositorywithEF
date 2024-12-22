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

            _context.Add(tutorial);
            _context.SaveChanges();
            return tutorial;

        }

        public Tutorial Delete(int id)
        {

            var tutorial = _context.Tutorials.Find(id);
            if (tutorial != null)
            {
                _context.Tutorials.Remove(tutorial);
                _context.SaveChanges();
            }
            return tutorial;
        }

        public IEnumerable<Tutorial> GetAllTutorials()
        {
            return _context.Tutorials.ToList();
        }

        public Tutorial GetTutorial(int id)
        {
            var tutorial = _context.Tutorials.Find(id);
            return tutorial;
        }

        public Tutorial Update(Tutorial tutorial)
        {
            _context.Update(tutorial);
            _context.SaveChanges();
            return tutorial;
        }

    }
}
