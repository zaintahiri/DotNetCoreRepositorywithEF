using DotNetCoreRepositorywithEF.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRepositorywithEF.Context
{
    public class TutorialDBContext:DbContext
    {

        public TutorialDBContext(DbContextOptions<TutorialDBContext> options) : base(options)
        {

        }
        public DbSet<Tutorial> Tutorials { get; set; }
    }
}
