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
        public DbSet<Article> Articles{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                new Article() { 
                    ArticleId=1,
                    ArticleTitle="Intorduction to Java",
                    ArticleContent="Java is the object oriented programming language",
                    TutorialId=1
                });
        }
    }
}
